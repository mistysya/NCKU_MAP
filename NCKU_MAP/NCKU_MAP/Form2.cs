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
        int mapID = 0;
        string findkeyword = null;//暫時丟資料庫
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

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            mapID++;
            Edit("INSERT INTO SceneInfo(mapID,SceneName,SceneType,SceneDescript,Address,Website,PhoneNumber,OpenTime,ImagePath,FindKeyword,Latitude,Longitude,IsMark)VALUES(N'" +
                tbxID.Text.Replace("'", "''") + "',N'" +
                tbxName.Text.Replace("'", "''") + "',N'" +
                tbxType.Text.Replace("'", "''") + "',N'" +
                tbxDescript.Text.Replace("'", "''") + "',N'" +
                tbxAddress.Text.Replace("'", "''") + "',N'" +
                tbxWebsite.Text.Replace("'", "''") + "',N'" +
                tbxPhoneNum.Text.Replace("'", "''") + "',N'" +
                tbxOpenTime.Text.Replace("'", "''") + "',N'" +
                tbxImgPath.Text.Replace("'", "''") + "','" +
                findkeyword + "',N'" +
                tbxLat.Text.Replace("'", "''") + "','" +
                tbxLng.Text.Replace("'", "''") + "'," +
                0 + ")");
            DataBindingsClear();
            Form2_Load(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mapInfoDataSet1.SceneInfo' 資料表。您可以視需要進行移動或移除。
            this.sceneInfoTableAdapter.Fill(this.mapInfoDataSet1.SceneInfo);
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM SceneInfo", cn);
            daCategory.Fill(ds, "SceneInfo");

            tbxLat.DataBindings.Add("Text", ds, "SceneInfo.Latitude");
            tbxLng.DataBindings.Add("Text", ds, "SceneInfo.Longitude");
            tbxID.DataBindings.Add("Text", ds, "SceneInfo.mapID");
            tbxName.DataBindings.Add("Text", ds, "SceneInfo.SceneName");
            tbxType.DataBindings.Add("Text", ds, "SceneInfo.SceneType");
            tbxWebsite.DataBindings.Add("Text", ds, "SceneInfo.Website");
            tbxPhoneNum.DataBindings.Add("Text", ds, "SceneInfo.PhoneNumber");
            tbxOpenTime.DataBindings.Add("Text", ds, "SceneInfo.OpenTime");
            tbxImgPath.DataBindings.Add("Text", ds, "SceneInfo.ImagePath");
            tbxAddress.DataBindings.Add("Text", ds, "SceneInfo.Address");
            tbxDescript.DataBindings.Add("Text", ds, "SceneInfo.SceneDescript");

            bm = this.BindingContext[ds, "SceneInfo"];
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
            tbxImgPath.DataBindings.Clear();
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
    }
}
