using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProject
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            chart1.Titles.Add("Share of each category");

            chart1.Series["s1"].Points.AddXY("Food", Form1.c1);
            chart1.Series["s1"].Points.AddXY("Clothes", Form1.c2);
            chart1.Series["s1"].Points.AddXY("Electronics", Form1.c3);
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
