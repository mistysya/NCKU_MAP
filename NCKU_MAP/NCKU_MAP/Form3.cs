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

        public Form3()
        {
            InitializeComponent();
        }
        BindingManagerBase bm;

        private void btnnew_Click(object sender, EventArgs e)
        {
            show_curriculum();
        }

        private void show_curriculum()
        {
            int num = 0;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                {
                    table[num] = new Button();
                    if (num < 11)
                    {
                        table[num].SetBounds(200 + 60 * i, 20 + 60 * j, 62, 62);
                        table[num].Enabled = false;
                        if (num < 10 && num > 0)
                            table[num].Text = num.ToString();
                    }
                    else
                        table[num].SetBounds(140 + 120 * i, 20 + 60 * j, 122, 62); //fix the gap
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
                    num++;
                }
        }

        private void  Button_Click(Object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            tempnum = Array.IndexOf(table, btnclick);
            gbxnewclass.Visible = true;
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new Rectangle(0, 0, 45, 45));
            btnsaveclass.Region = new Region(aCircle);
            tempbtn = (Button)sender;
            tbxclass.Text = tbxplace.Text = "";
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
            if (ds.Tables[0].Rows.Count != 0)
                btnnew.Enabled = false;
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
                /*try
                {
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                        "Integrated Security=True";
                    DataSet ds = new DataSet();
                    SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM class", cn);
                    daCategory.Fill(ds, "class");

                    Edit("INSERT INTO curriculums(背景色)VALUES(N'" +
                        tbxclass.Text.Replace("'", "''") + "',N'" +
                        tbxplace.Text.Replace("'", "''") + "',N'" +
                        tempnum + ")");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataBindingsClear();*/
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
                DataSet ds = new DataSet();
                SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM class", cn);
                daCategory.Fill(ds, "class");

                tbxclass.DataBindings.Add("Text", ds, "class.課名");
                tbxplace.DataBindings.Add("Text", ds, "class.地點");
                bm = this.BindingContext[ds, "class"];

                string sqlstr = "SELECT 課表id FROM class where 課表id = " + tempnum.ToString();
                //if(tempbtn.Text == "")
                Edit("INSERT INTO class(課名,地點,課程id)VALUES(N'" +
                        tbxclass.Text.Replace("'", "''") + "',N'" +
                        tbxplace.Text.Replace("'", "''") + "'," +
                        tempnum + ")");
                /*else
                    Edit("UPDATE class SET 課名= '" + tbxclass.Text.Replace("'", "''") +
                        "',地點='" + tbxplace.Text.Replace("'", "''") + "'");*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBindingsClear();
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
            for(int i = 12; i < 66; i++)
            {
                table[i].DataBindings.Clear();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            show_curriculum();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|curriculums.mdf;" +
                    "Integrated Security=True";
                DataSet ds = new DataSet();
                SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM class", cn);
                daCategory.Fill(ds, "class");
                ds.Tables["class"].Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
