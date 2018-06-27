using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NCKU_MAP
{
    public partial class Form3 : Form
    {
        public Form1 f1;
        private TextBox tbxS;
        private ListBox lbxS;
        Button[] table = new Button[66];
        private Button tempbtn = null;
        private int tempnum = 0;
        int edit_or_view;

        public Form3(Form1 newf1)
        {
            InitializeComponent();
            for (int i = 0; i < 66; i++)
            {
                table[i] = new Button();
            }
            f1 = newf1;
        }
        //BindingManagerBase bm;

        private void btnnew_Click(object sender, EventArgs e)
        {
            edit_or_view = 0;
            show_curriculum(0);//edit button call
            readfromdatabase(0);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            edit_or_view = 1;
            show_curriculum(1);//view button call
            readfromdatabase(1);
            gbxnewclass.Visible = false;
            /*for (int i = 0; i < 66; i++)
            {
                table[i].Visible = true;
            }*/
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認刪除課表?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 66; i++)
                    Edit("DELETE FROM class WHERE 課程id=" + i.ToString());
                for (int i = 0; i < 66; i++)
                {
                    table[i].Visible = false;
                }
            }
            gbxnewclass.Visible = false;
        }

        private void show_curriculum(int sel)
        {
            int num = 0;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                {
                    //table[num] = new Button();
                    if (num < 11)
                    {
                        table[num].SetBounds(200 + 60 * i, 20 + 60 * j, 62, 62);
                        table[num].Enabled = false;
                        if (num < 10 && num > 0)
                            table[num].Text = num.ToString();
                    }
                    else
                        table[num].SetBounds(140 + 120 * i, 20 + 60 * j, 122, 62); //fix the gap between buttons
                    switch (num)
                    {
                        case 11:
                            table[num].Text = "星期一"; table[num].Enabled = false; break;
                        case 22:
                            table[num].Text = "星期二"; table[num].Enabled = false; break;
                        case 33:
                            table[num].Text = "星期三"; table[num].Enabled = false; break;
                        case 44:
                            table[num].Text = "星期四"; table[num].Enabled = false; break;
                        case 55:
                            table[num].Text = "星期五"; table[num].Enabled = false; break;
                    }
                    if (num == 10)
                        table[num].Text = "A";
                    table[num].FlatStyle = FlatStyle.Flat;
                    table[num].FlatAppearance.BorderColor = Color.LightCoral;
                    table[num].FlatAppearance.BorderSize = 2;
                    Controls.Add(table[num]);
                    table[num].Click += new System.EventHandler(this.Button_Click);//let all buttons share the same function
                    /*MessageBox.Show(sel.ToString() + " " + i.ToString());
                    if (sel == 1)
                        table[num].Enabled = false;
                    else if (sel == 0 && (num >= 12 && num <= 21) || (num >= 23 && num <= 32) || (num >= 34 && num <= 43) || (num >= 45 && num <= 54) || (num >= 56 && num <= 65))
                    {
                        table[num].Enabled = true;
                    }*/

                    num++;
                }
        }

        private void readfromdatabase(int sel)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                "Integrated Security=True";
            cn.Open();

            string sqlstr, temp;
            for (int i = 0; i < 66; i++)
            {
                sqlstr = "SELECT 課名 FROM class where 課程id = " + i.ToString();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    temp = reader[0].ToString();
                    reader.Close();
                    sqlstr = "SELECT 地點 FROM class where 課程id = " + i.ToString();
                    cmd = new SqlCommand(sqlstr, cn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    table[i].Text = temp + "\n" + reader[0].ToString();
                    reader.Close();
                    sqlstr = "SELECT A,R,G,B FROM class where 課程id = " + i.ToString();
                    cmd = new SqlCommand(sqlstr, cn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader[0].ToString() == "")
                    {
                        reader.Close();
                        continue;
                    }
                    int A = int.Parse(reader["A"].ToString());
                    int R = int.Parse(reader["R"].ToString());
                    int G = int.Parse(reader["G"].ToString());
                    int B = int.Parse(reader["B"].ToString());
                    table[i].BackColor = Color.FromArgb(R, G, B);
                    reader.Close();
                }
                else if ((i >= 12 && i <= 21) || (i >= 23 && i <= 32) || (i >= 34 && i <= 43) || (i >= 45 && i <= 54) || (i >= 56 && i <= 65))
                {
                    reader.Close();
                    table[i].Text = "";
                    if (sel == 0)
                        table[i].Enabled = true;
                    if (sel == 1)
                        table[i].Enabled = false;
                }
                else
                    reader.Close();
            }
        }

        private void  Button_Click(Object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            tempnum = Array.IndexOf(table, btnclick);
            tempbtn = (Button)sender;
            if (edit_or_view == 0)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string sqlstr = "SELECT 課名 FROM class where 課程id = " + tempnum.ToString();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    tbxclass.Text = reader[0].ToString();
                else
                    tbxclass.Text = "";
                reader.Close();

                sqlstr = "SELECT 地點 FROM class where 課程id = " + tempnum.ToString();
                cmd = new SqlCommand(sqlstr, cn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                    tbxplace.Text = reader[0].ToString();
                else
                    tbxplace.Text = "";
                reader.Close();

                gbxnewclass.Visible = true;
                System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
                aCircle.AddEllipse(new Rectangle(0, 0, 45, 45));
                btnsaveclass.Region = new Region(aCircle);
                btndelclass.Region = new Region(aCircle);
                //tbxclass.Text = tbxplace.Text = "";
                //DataBindings.Clear();
            }
            if(edit_or_view == 1)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string sqlstr = "SELECT 地點 FROM class where 課程id = " + tempnum.ToString();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string search  = reader[0].ToString();
                reader.Close();
                cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                        "Integrated Security=True";
                cn.Open();

                sqlstr = "SELECT * FROM SceneInfo where SceneName = N'" + search + "'";
                cmd = new SqlCommand(sqlstr, cn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    f1.FindLocation(search);
                else
                    f1.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { search });
                reader.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM class", cn);
            daCategory.Fill(ds, "class");
            //tbxclass.DataBindings.Add("Text", ds, "class.課名");
            //tbxplace.DataBindings.Add("Text", ds, "class.地點");
            //bm = this.BindingContext[ds, "class"];
            lbxS = lbxClassLocate;
            //tbxclass.Text = "";
            //tbxplace.Text = "";
        }

        private void change(object sender, int sel)
        {
            Button btn = (Button)sender;
            if(sel == 1)
            {
                btn.Text = tbxclass.Text + "\n" + tbxplace.Text;
            }
        }

        private void btnbackcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tempbtn.BackColor = colorDialog1.Color;
                //MessageBox.Show(tempbtn.BackColor.R.ToString() + " " + tempbtn.BackColor.R);
                try
                {
                    string command = "UPDATE class SET A= " + tempbtn.BackColor.A + " where 課程id=" + tempnum.ToString();
                    Edit(command);
                    command = "UPDATE class SET R= " + tempbtn.BackColor.R + " where 課程id=" + tempnum.ToString();
                    Edit(command);
                    command = "UPDATE class SET G= " + tempbtn.BackColor.G + " where 課程id=" + tempnum.ToString();
                    Edit(command);
                    command = "UPDATE class SET B= " + tempbtn.BackColor.B + " where 課程id=" + tempnum.ToString();
                    Edit(command);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnsaveclass_Click(object sender, EventArgs e)
        {
            change(tempbtn, 1);
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                        "Integrated Security=True";
                cn.Open();

                string sqlstr = "SELECT * FROM SceneInfo where SceneName = N'" + tbxplace.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    DialogResult result = MessageBox.Show("是否要新增該地點到資料庫？(可自行針對地圖標記地點做微調)", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //MessageBox.Show(tbxplace.Text);
                        f1.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxplace.Text }); // call javascript to Search
                        Task.Delay(1000);
                        f1.f2 = new Form2();
                        f1.f2.Show();
                        f1.webBrowser1.Document.InvokeScript("setAddMarker");
                    }
                }
                reader.Close();
                cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                sqlstr = "SELECT 課程id FROM class where 課程id = " + tempnum.ToString();
                cmd = new SqlCommand(sqlstr, cn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Edit("UPDATE class SET 課名= N'" + tbxclass.Text +
                        "',地點= N'" + tbxplace.Text + "' where 課程id=" + tempnum.ToString());

                    //Edit("UPDATE class SET 課名= '" + tbxclass.Text.Replace("'", "''") +
                    //    "',地點='" + tbxplace.Text.Replace("'", "''") + "where 課程id=" + tempnum.ToString() + "'");
                    reader.Close();
                    //DataBindingsClear();
                    //Form3_Load(sender, e);
                }
                else
                {
                    Edit("INSERT INTO class(課名,地點,課程id)VALUES(N'" +
                        tbxclass.Text.Replace("'", "''") + "',N'" +
                        tbxplace.Text.Replace("'", "''") + "'," +
                        tempnum + ")");
                    //DataBindingsClear();
                    //Form3_Load(sender, e);
                }
                reader.Close();
                tbxplace.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //DataBindingsClear();
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*void DataBindingsClear()
        {
            tbxclass.DataBindings.Clear();
            tbxplace.DataBindings.Clear();
        }
        
        private void tbxplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxplace_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbxplace_KeyDown(object sender, KeyEventArgs e)
        {

        }*/
        public void tbxplace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // press "Enter"
            {
                if (lbxClassLocate.SelectedIndex >= 0)
                {
                    SceneInfo tmp = (SceneInfo)lbxClassLocate.SelectedItem;
                    tbxplace.Text = tmp.sceneName_;
                    //f1.FindLocation(tmp.sceneName_);

                    /*
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                        "Integrated Security=True";
                    cn.Open();
                    string sqlstr = "SELECT * FROM SceneInfo where SceneName = N'" + tmp.sceneName_ + "'";
                    //SceneType,SceneDescript,Address,Website,PhoneNumber,OpenTime
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    reader.Close();*/
                }
                else
                {
                    //f1.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxplace.Text }); // call javascript to Search
                    //可以在這邊加入是否要新增地點之選項
                }
                lbxClassLocate.Visible = false; // dont show AutoComplete
            }
        }
        public void tbxplace_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox eObj = sender as TextBox;
            tbxS = eObj;
            if (eObj.Name == "tbxplace")
            {
                lbxS = lbxClassLocate;
            }
            else;
            if (tbxS.Text == "")
            {
                tbxS.Select(tbxS.Text.Length, 1);
                lbxS.Visible = false;
                return;
            }
            // Press Up & Left
            if (e.KeyCode == Keys.Up)
            {
                if (lbxS.SelectedIndex > -1)
                {
                    lbxS.SelectedIndex--;
                    tbxS.Select(tbxS.Text.Length, 1);
                }
            }
            // Press Down & Right
            else if (e.KeyCode == Keys.Down)
            {
                if (lbxS.SelectedIndex < lbxS.Items.Count - 1)
                {
                    lbxS.SelectedIndex++;
                    tbxS.Select(tbxS.Text.Length, 1);
                }
            }
        }
        public void tbxplace_TextChanged(object sender, EventArgs e)
        {
            TextBox eObj = sender as TextBox;
            tbxS = eObj;
            // IList<string> autocompleteResult = PredicSearch(tbxSearch.Text);
            PredictionInfo pred = new PredictionInfo(tbxS.Text);
            List<SceneInfo> predList = pred.GetList(5);
            //MessageBox.Show(predList.Count.ToString() + " " + tbxSearch.Text);
            if (predList.Count > 0 && predList != null)
            {
                lbxS.DataSource = predList;
                lbxS.DisplayMember = "SceneName";
                lbxS.Visible = true;
                lbxS.SelectedIndex = -1;
            }
            else
                lbxS.Visible = false;
        }
        public class SceneInfo : IComparable
        {
            public string sceneName_;
            public int samewords_;
            public int leavewords_; // leave words
            public SceneInfo(string sceneName, int samewords, int leavewords)
            {
                this.sceneName_ = sceneName;
                this.samewords_ = samewords;
                this.leavewords_ = leavewords;
            }
            public int CompareTo(object obj)
            {
                SceneInfo tobeCompared = (SceneInfo)obj;
                if (this.samewords_ > tobeCompared.samewords_)
                    return -1;
                else if (this.samewords_ == tobeCompared.samewords_)
                {
                    if (this.leavewords_ > tobeCompared.leavewords_)
                        return 1;
                    else if (this.leavewords_ == tobeCompared.leavewords_)
                        return 0;
                    else
                        return -1;
                }
                else
                    return 1;
            }
            public string SceneName
            {
                get
                {
                    return sceneName_;
                }
            }
        }
        public class PredictionInfo
        {
            public string input_;
            private List<SceneInfo> sceneData_ = new List<SceneInfo>();
            public PredictionInfo(string input)
            {
                this.input_ = input;
                // import Database
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                string sqlstr = "SELECT SceneName FROM SceneInfo";
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                // store Data
                while (reader.Read())
                {
                    // Add data & calculate priority
                    string r = reader.GetString(0);
                    int same = Compare(reader.GetString(0));
                    int leave = r.Length - same;
                    SceneInfo temp = new SceneInfo(r, same, leave);
                    sceneData_.Add(temp);
                }
                reader.Close();
                // sort priority
                sceneData_.Sort();
            }
            public int Compare(string data)
            {
                int count = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    int tmp = 0;
                    for (int j = i, k = 0; k < input_.Length; k++, j++)
                    {
                        if (j >= data.Length)
                            break;
                        if (input_[k] == data[j])
                            tmp++;
                    }
                    count = Math.Max(count, tmp);
                }
                return count;
            }
            public void Show()
            {
                string tmp = "";
                foreach (SceneInfo s in sceneData_)
                    tmp += (s.sceneName_ + " " + s.samewords_ + " " + s.leavewords_ + "\n");
                MessageBox.Show(tmp);
            }
            public List<SceneInfo> GetList(int num)
            {
                List<SceneInfo> result = new List<SceneInfo>();
                if (num > sceneData_.Count)
                    for (int i = 0; i < sceneData_.Count; i++)
                    {
                        if (sceneData_[i].samewords_ > 0)
                            result.Add(sceneData_[i]);
                    }
                else
                    for (int i = 0; i < num; i++)
                    {
                        if (sceneData_[i].samewords_ > 0)
                            result.Add(sceneData_[i]);
                    }
                return result;
            }
        }

        private void btndelclass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認刪除此欄位?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Edit("DELETE FROM class WHERE 課程id=" + tempnum.ToString());
                tbxclass.Text = tbxplace.Text = "";
            }
        }
    }
}
