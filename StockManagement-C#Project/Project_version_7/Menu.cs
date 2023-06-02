using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_version_7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodsStockForm form = new GoodsStockForm(); 
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierForm form = new SupplierForm();
            form.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualize the goods that are in stock. \nGoods can be added, deleted or updated in the data base. The database used is in a SQLite file.", "Info Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualize the list of suppliers for the goods in stock. \nHere you can find information about each supplier.", "Info Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The list of operations done with the goods in stock (aqusition/sell).", "Info Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
