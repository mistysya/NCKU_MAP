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
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !lblScene.Text.Equals("")) // press "Enter"
            {
                this.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxSearch.Text }); // call javascript to Search
                panel1.Location = new Point(0, 0); // move sidebar
                btnSide.Location = new Point(panel1.Right, 0); // move sideButton
                btnSide.Visible = true; // show sideButton
                lblScene.Text = tbxSearch.Text; // update lblScene
            }
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
        }

        private void btnclosesheet_Click(object sender, EventArgs e)
        {
            panel2.Visible = panlogo.Visible = false;
        }
    }
}
