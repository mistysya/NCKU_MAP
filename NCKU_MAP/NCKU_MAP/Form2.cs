using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKU_MAP
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        public Form2()
        {
            InitializeComponent();            
        }
        public void UpdateLatLng(double lat, double lng)
        {
            tbxLat.Text = lat.ToString();
            tbxLng.Text = lng.ToString();
        }
    }
}
