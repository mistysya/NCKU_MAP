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

namespace Google_Maps_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("Google_Maps_CS.Maps.htm"));
            //StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("Google_Maps_CS.Gmaps.htm"));
            /*
            webBrowser1.DocumentText = reader.ReadToEnd();
            string filename = @"C:\Users\Misty\Documents\C#\Google_Maps\Google_Maps_CS\Gmaps.htm";
            Process.Start(filename);*/
            panel1.Location = new Point(-panel1.Width, 0);
            btnSide.Location = new Point(panel1.Right, 0);
            btnSide.Visible = false;
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format(@"C:\Users\Misty\Documents\C#\Google_Maps\Google_Maps_CS\Gmaps.htm"));
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !lblScene.Text.Equals(""))
            {
                this.webBrowser1.Document.InvokeScript("GetAddressMarker", new Object[] { tbxSearch.Text });
                panel1.Location = new Point(0, 0);
                btnSide.Location = new Point(panel1.Right, 0);
                btnSide.Visible = true;
                lblScene.Text = tbxSearch.Text;
            }
        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            if(panel1.Right == 0)
            {
                panel1.Location = new Point(0, 0);
                btnSide.Location = new Point(panel1.Right, 0);
                btnSide.Text = "‹";
            }
            else
            {
                panel1.Location = new Point(-panel1.Width, 0);
                btnSide.Location = new Point(panel1.Right, 0);
                btnSide.Text = "›";
            }
        }
    }
}
