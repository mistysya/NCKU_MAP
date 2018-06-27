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
    public partial class Form2 : Form
    {
        public Form1 f1;

        public Form2()
        {
            InitializeComponent();
        }

        BindingManagerBase bm;

        public void UpdateLatLng(double lat, double lng)
        {
            tbxLat.Text = lat.ToString();
            tbxLng.Text = lng.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM SceneInfo", cn);
            daCategory.Fill(ds, "SceneInfo");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SceneInfo";

            tbxLat.DataBindings.Add("Text", ds, "SceneInfo.Latitude");
            tbxLng.DataBindings.Add("Text", ds, "SceneInfo.Longitude");
            tbxID.DataBindings.Add("Text", ds, "SceneInfo.mapID");
            tbxName.DataBindings.Add("Text", ds, "SceneInfo.SceneName");
            tbxType.DataBindings.Add("Text", ds, "SceneInfo.SceneType");
            tbxWebsite.DataBindings.Add("Text", ds, "SceneInfo.Website");
            tbxPhoneNum.DataBindings.Add("Text", ds, "SceneInfo.PhoneNumber");
            tbxOpenTime.DataBindings.Add("Text", ds, "SceneInfo.OpenTime");
            tbxAddress.DataBindings.Add("Text", ds, "SceneInfo.Address");
            tbxDescript.DataBindings.Add("Text", ds, "SceneInfo.SceneDescript");

            bm = this.BindingContext[ds, "SceneInfo"];
        }


        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                    "Integrated Security=True";
                Edit("INSERT INTO SceneInfo(mapID,SceneName,SceneType,SceneDescript,Address,Website,PhoneNumber,OpenTime,ImagePath,Latitude,Longitude,IsMark)VALUES(N'" +
                    tbxID.Text.Replace("'", "''") + "',N'" +
                    tbxName.Text.Replace("'", "''") + "',N'" +
                    tbxType.Text.Replace("'", "''") + "',N'" +
                    tbxDescript.Text.Replace("'", "''") + "',N'" +
                    tbxAddress.Text.Replace("'", "''") + "',N'" +
                    tbxWebsite.Text.Replace("'", "''") + "',N'" +
                    tbxPhoneNum.Text.Replace("'", "''") + "',N'" +
                    tbxOpenTime.Text.Replace("'", "''") + "',N'" +
                    tbxLat.Text.Replace("'", "''") + "','" +
                    tbxLng.Text.Replace("'", "''") + "'," +
                    0 + ")");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBindingsClear();
            Form2_Load(sender, e);
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
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
            tbxLat.DataBindings.Clear();
            tbxLng.DataBindings.Clear();
            tbxID.DataBindings.Clear();
            tbxName.DataBindings.Clear();
            tbxType.DataBindings.Clear();
            tbxWebsite.DataBindings.Clear();
            tbxPhoneNum.DataBindings.Clear();
            tbxOpenTime.DataBindings.Clear();
            tbxAddress.DataBindings.Clear();
            tbxDescript.DataBindings.Clear();
        }

        private void btnDeleteFromDatabase_Click(object sender, EventArgs e)
        {
            Edit("DELETE FROM SceneInfo WHERE mapID='" +
                tbxID.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form2_Load(sender, e);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Edit("UPDATE SceneInfo SET SceneName= N'" + tbxName.Text.Replace("'", "''") +
                "',SceneType=N'" + tbxType.Text.Replace("'", "''") +
                "',SceneDescript=N'" + tbxDescript.Text.Replace("'", "''") +
                "',Address=N'" + tbxAddress.Text.Replace("'", "''") +
                "',Website=N'" + tbxWebsite.Text.Replace("'", "''") +
                "',PhoneNumber=N'" + tbxPhoneNum.Text.Replace("'", "''") +
                "',OpenTime=N'" + tbxOpenTime.Text.Replace("'", "''") +
                "',Latitude=N'" + tbxLat.Text.Replace("'", "''") +
                "',Longitude=N'" + tbxLng.Text.Replace("'", "''") +
                "' WHERE mapID=N'" + tbxID.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form2_Load(sender, e);
        }
    }
}
