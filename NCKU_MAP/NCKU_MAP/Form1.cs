using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;

namespace NCKU_MAP
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        public Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(-panel1.Width, 0); // initiallize sidebar location
            btnSide.Location = new Point(panel1.Right, 0); // initiallize sideButton location
            btnSide.Visible = false; // hide sideButton
            string fullPath = System.Environment.CurrentDirectory; // get html filepath
            fullPath = fullPath.Replace("\\bin\\Debug", "\\Gmaps.htm"); // normalize
            fullPath = fullPath.Replace("\\", "/"); // normalize
            this.webBrowser1.Url = new Uri(fullPath); // show map on webBrowser1
            webBrowser1.ObjectForScripting = this;
            panel2.Dock = DockStyle.Left;
            panlogo.Location = new Point(0, 0);
            //importDatabase();
            //cbxSearchBarImportData();
            //tbxSearchBarImportDate();
        }


        private void btnSide_Click(object sender, EventArgs e)
        {
            if(panel1.Right == 0) // show sideButton
            {
                panel1.Location = new Point(0, 0);
                btnSide.Location = new Point(panel1.Right, 0);
                btnSide.Text = "‹";
            }
            else // hide sideButton
            {
                panel1.Location = new Point(-panel1.Width, 0);
                btnSide.Location = new Point(panel1.Right, 0);
                btnSide.Text = "›";
            }
        }

        private void btnAddScene_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
            this.webBrowser1.Document.InvokeScript("setAddMarker");
        }

        public void UpdateLatLng(double lat, double lng)
        {
            f2.UpdateLatLng(lat, lng);
            //MessageBox.Show("You did it!", "UpdateLatLng");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = panlogo.Visible = true;
            tbxSearch.Visible = false;
        }

        private void btnclosesheet_Click(object sender, EventArgs e)
        {
            panel2.Visible = panlogo.Visible = false;
            tbxSearch.Visible = true;
        }

        /*
        private void cbxSearchBarImportData()
        {
            cbxSearchBar.DataSource = ds.Tables["SceneInfo"];
            cbxSearchBar.DisplayMember = "SceneName";
        }*/
        /*
        private void tbxSearchBarImportDate()
        {
            //AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acc = new AutoCompleteStringCollection();//宣告acc為字串集合器
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                "Integrated Security=True";
            cn.Open();
            string sqlstr = "SELECT SceneName FROM SceneInfo";
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                acc.Add(reader.GetString(0));
            }
            reader.Close();
            /*foreach (DataRow dr in ds)
            DataRow[] dr = hw2DataSet.Communication.Select();//宣告DataRow物件陣列，並用Select指令將資料表存入
            for (int i = 0; i < dr.Length; i++)
            {
                acc.Add(dr[i][comboBox1.SelectedItem.ToString()].ToString().Trim());//將指定欄位內的資料值加入字串集合器
            }*//*
            tbxSearch.AutoCompleteCustomSource = acc;//將textBox1的AutoCompleteCustomSource屬性設定為acc
        }
    */
    /*
        private void importDatabase()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                "Integrated Security=True";
            ds = new DataSet();
            SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM SceneInfo", cn);
            daCategory.Fill(ds, "SceneInfo");
        }
        private DataSet ds;
        */
        void FindLocation(string find)
        {
            lbxSearchBar.Visible = false;
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                string sqlstr = "SELECT Latitude FROM SceneInfo where SceneName = N'" + find + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string lat = reader[0].ToString();
                reader.Close();
                sqlstr = "SELECT Longitude FROM SceneInfo where SceneName = N'" + find + "'";
                cmd = new SqlCommand(sqlstr, cn);
                reader = cmd.ExecuteReader();
                reader.Read();
                string lng = reader[0].ToString();
                this.webBrowser1.Document.InvokeScript("Locate", new Object[] { lat, lng }); // call javascript to Search
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !lblScene.Text.Equals("")) // press "Enter"
            {
                if (lbxSearchBar.SelectedIndex >= 0)
                {
                    SceneInfo tmp = (SceneInfo)lbxSearchBar.SelectedItem;
                    tbxSearch.Text = tmp.sceneName_;
                    FindLocation(tmp.sceneName_);
                }
                else
                    this.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxSearch.Text }); // call javascript to Search
                panel1.Location = new Point(0, 0); // move sidebar
                btnSide.Location = new Point(panel1.Right, 0); // move sideButton
                btnSide.Visible = true; // show sideButton
                lblScene.Text = tbxSearch.Text; // update lblScene
            }
        }
        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                tbxSearch.Select(tbxSearch.Text.Length, 1);
                lbxSearchBar.Visible = false;
                return;
            }
            // Press Up & Left
            if(e.KeyCode == Keys.Up)
            {
                if (lbxSearchBar.SelectedIndex > -1)
                {
                    lbxSearchBar.SelectedIndex--;
                    tbxSearch.Select(tbxSearch.Text.Length, 1);
                }
            }
            // Press Down & Right
            else if (e.KeyCode == Keys.Down)
            {
                if (lbxSearchBar.SelectedIndex < lbxSearchBar.Items.Count - 1)
                {
                    lbxSearchBar.SelectedIndex++;
                    tbxSearch.Select(tbxSearch.Text.Length, 1);
                }
            }
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            // IList<string> autocompleteResult = PredicSearch(tbxSearch.Text);
            PredictionInfo pred = new PredictionInfo(tbxSearch.Text);
            List<SceneInfo> predList = pred.GetList(5);
            //MessageBox.Show(predList.Count.ToString() + " " + tbxSearch.Text);
            if (predList.Count > 0)
            {
                lbxSearchBar.DataSource = predList;
                lbxSearchBar.DisplayMember = "SceneName";
                lbxSearchBar.Visible = true;
                lbxSearchBar.SelectedIndex = -1;
            }
            else
                lbxSearchBar.Visible = false;
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
                for(int i = 0; i < data.Length; i++)
                {
                    int tmp = 0;
                    for(int j = i, k = 0; k < input_.Length; k++, j++)
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
                    tmp += (s.sceneName_ + " " + s.samewords_ + " " + s.leavewords_ +"\n");
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

        private void btnguide_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnSide.Visible = false;
            tbxSearch.Visible = false;
            panel3.Dock = DockStyle.Left;
            panel3.Visible = true;
            tbxgoal.Text = lblScene.Text;
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new Rectangle(0, 0, 50, 50));
            btnstartguide.Region = new Region(aCircle);
        }

        private void btnguide_MouseEnter_1(object sender, EventArgs e)
        {
            lblguide.Visible = true;
        }

        private void btnguide_MouseLeave_1(object sender, EventArgs e)
        {
            lblguide.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
            btnSide.Visible = true;
            tbxSearch.Visible = true;

        }
    }
}
