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
        Button[] table = new Button[66];
        public Button tempbtn;
        public int tempnum;
        int edit_or_view;
        public Form1 f1;

        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < 66; i++)
            {
                table[i] = new Button();
            }
        }
        BindingManagerBase bm;

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
                    table[i].BackColor = Color.FromArgb(A, R, G, B);
                    reader.Close();
                }
                else if ((i >= 12 && i <= 21) || (i >= 23 && i <= 32) || (i >= 34 && i <= 43) || (i >= 45 && i <= 54) || (i >= 56 && i <= 65))
                {
                    reader.Close();
                    table[i].Text = "";
                }
                else
                    reader.Close();
            }
        }

        private void  Button_Click(Object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            tempnum = Array.IndexOf(table, btnclick);
            if (edit_or_view == 0)
            {
                gbxnewclass.Visible = true;
                System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
                aCircle.AddEllipse(new Rectangle(0, 0, 45, 45));
                btnsaveclass.Region = new Region(aCircle);
                tempbtn = (Button)sender;
                //tbxclass.Text = tbxplace.Text = "";
                DataBindings.Clear();
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
                MessageBox.Show(search);
                //f1.FindLocation(search);
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
            tbxclass.DataBindings.Add("Text", ds, "class.課名");
            tbxplace.DataBindings.Add("Text", ds, "class.地點");
            bm = this.BindingContext[ds, "class"];
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
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string sqlstr = "SELECT 課程id FROM class where 課程id = " + tempnum.ToString();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Edit("UPDATE class SET 課名= N'" + tbxclass.Text +
                        "',地點= N'" + tbxplace.Text + "' where 課程id=" + tempnum.ToString());

                    //Edit("UPDATE class SET 課名= '" + tbxclass.Text.Replace("'", "''") +
                    //    "',地點='" + tbxplace.Text.Replace("'", "''") + "where 課程id=" + tempnum.ToString() + "'");
                    reader.Close();
                    DataBindingsClear();
                    Form3_Load(sender, e);
                }
                else
                {
                    Edit("INSERT INTO class(課名,地點,課程id)VALUES(N'" +
                        tbxclass.Text.Replace("'", "''") + "',N'" +
                        tbxplace.Text.Replace("'", "''") + "'," +
                        tempnum + ")");
                    DataBindingsClear();
                    Form3_Load(sender, e);
                }
                    
                
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
        void DataBindingsClear()
        {
            tbxclass.DataBindings.Clear();
            tbxplace.DataBindings.Clear();
        }

    }
}
