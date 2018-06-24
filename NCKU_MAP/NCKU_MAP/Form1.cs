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
        public Form3 f3 = new Form3();
        private TextBox tbxS;
        private ListBox lbxS;
        //public WebBrowser webBrowser1 = webBrowserGmap;
        public Form1()
        {
            InitializeComponent();
            f3.f1 = this;
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
            panelNavigate.Location = new Point(-panelNavigate.Width, 0); // initiallize sidebar location
            panlogo.Location = new Point(0, 0);
            lbxS = lbxSearchBar;
        }
        public void UpdateLatLng(double lat, double lng)
        {
            f2.UpdateLatLng(lat, lng);
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
        private void btncloseguide_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Document.InvokeScript("removeRoute");
            panelNavigate.Visible = false;
            btnSide.Visible = true;
        }
        private void btnguide_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new Rectangle(0, 0, 35, 35));
            btnNavigateFind.Region = new Region(aCircle);
            panelNavigate.Location = new Point(0, 0);
            panelNavigate.Visible = true;
            tbxEnd.Text = lblScene.Text;
            lbxS = lbxNavigate;
            btnSide.Visible = false;
            lbxNavigate.Visible = false;
            lbxSearchBar.Visible = false;
        }
        private void lbxStore_Load_Data()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                "Integrated Security=True";
            cn.Open();
            string sqlstr = "SELECT SceneName FROM SceneInfo where IsMark='1'";
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            lbxStorelist.BeginUpdate();
            lbxStorelist.Items.Clear();
            while(reader.Read())
            {
                //MessageBox.Show(reader.GetString(0));
                lbxStorelist.Items.Add(reader.GetString(0));
            }
            reader.Close();
            cn.Close();
            lbxStorelist.EndUpdate();
        }
        private void Navigate()
        {
            //MessageBox.Show("Start search");
            try
            {
                string[] naviSceneName = { tbxStart.Text, tbxEnd.Text };
                string[] naviLatlng = new string[4];
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MapInfo.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        string sqlstr;
                        if (i % 2 == 0)
                            sqlstr = "SELECT Latitude FROM SceneInfo where SceneName = N'" + naviSceneName[i / 2] + "'";
                        else
                            sqlstr = "SELECT Longitude FROM SceneInfo where SceneName = N'" + naviSceneName[i / 2] + "'";
                        SqlCommand cmd = new SqlCommand(sqlstr, cn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            naviLatlng[i] = reader[0].ToString();
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            if (i % 2 == 0)
                            {
                                naviLatlng[i] = "NOTINDATABASE";
                                naviLatlng[i + 1] = naviSceneName[i / 2];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.webBrowser1.Document.InvokeScript("calcRoute", new Object[] { naviLatlng[0], naviLatlng[1], naviLatlng[2], naviLatlng[3] });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNavigateFind_Click(object sender, EventArgs e)
        {
            if (tbxStart.Text != "" && tbxEnd.Text != "")
                Navigate();
        }
        private void tbxStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox eObj = sender as TextBox;
            tbxS = eObj;
            if (e.KeyCode == Keys.Enter && !lblScene.Text.Equals("")) // press "Enter"
            {
                if (lbxNavigate.SelectedIndex >= 0)
                {
                    SceneInfo tmp = (SceneInfo)lbxNavigate.SelectedItem;
                    tbxS.Text = tmp.sceneName_;
                }
                lbxNavigate.Visible = false; // dont show AutoComplete
                if (tbxStart.Text != "" && tbxEnd.Text != "")
                    Navigate();
            }
        }
        public void FindLocation(string find)
        {
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
        public void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !lblScene.Text.Equals("")) // press "Enter"
            {
                if (lbxSearchBar.SelectedIndex >= 0)
                {
                    SceneInfo tmp = (SceneInfo)lbxSearchBar.SelectedItem;
                    tbxSearch.Text = tmp.sceneName_;
                    FindLocation(tmp.sceneName_);
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
                    lblType.Text = reader["SceneType"].ToString();
                    tbxDescript.Text = reader["SceneDescript"].ToString();
                    lblAddress.Text = reader["Address"].ToString();
                    lblWebsite.Text = reader["Website"].ToString();
                    lblPhoneNum.Text = reader["PhoneNumber"].ToString();
                    lblOpenTime.Text = reader["OpenTime"].ToString();
                    reader.Close();
                }
                else
                    this.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxSearch.Text }); // call javascript to Search
                panel1.Location = new Point(0, 0); // move sidebar
                btnSide.Location = new Point(panel1.Right, 0); // move sideButton
                btnSide.Visible = true; // show sideButton
                lblScene.Text = tbxSearch.Text; // update lblScene
                lbxSearchBar.Visible = false; // dont show AutoComplete
            }
        }
        public void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox eObj = sender as TextBox;
            tbxS = eObj;
            if (eObj.Name == "tbxSearch")
            {
                lbxS = lbxSearchBar;
            }
            else if (eObj.Name == "tbxEnd" || eObj.Name == "tbxStart")
            {
                lbxS = lbxNavigate;
            }
            else;
            if (tbxS.Text == "")
            {
                tbxS.Select(tbxS.Text.Length, 1);
                lbxS.Visible = false;
                return;
            }
            // Press Up & Left
            if(e.KeyCode == Keys.Up)
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
        public void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox eObj = sender as TextBox;
            tbxS = eObj;
            // IList<string> autocompleteResult = PredicSearch(tbxSearch.Text);
            PredictionInfo pred = new PredictionInfo(tbxS.Text);
            List<SceneInfo> predList = pred.GetList(5);
            //MessageBox.Show(predList.Count.ToString() + " " + tbxSearch.Text);
            if (predList.Count > 0)
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

        private void btnclasstable_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void btnsaved_Click(object sender, EventArgs e)
        {
            lbxStore_Load_Data();
            panel2.Visible = panlogo.Visible = false;
            panelStoreList.Location = new Point(0, 0);
            panelStoreList.Visible = true;
        }

        private void btnStoreClose_Click(object sender, EventArgs e)
        {
            panel2.Visible = panlogo.Visible = true;
            panelStoreList.Visible = false;
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            Edit("UPDATE SceneInfo SET IsMark = 1 where SceneName = N'" + lblScene.Text + "'");
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

        private void lbxStorelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lbxStorelist.SelectedItem.ToString();
            FindLocation(curItem);
        }
    }
}
