using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ShopProject
{
    public partial class Form1 : Form
    {
        private List<Product> Products = new List<Product>();
        private const string ConnectionString = "Data Source=C:\\Users\\Bogdan\\source\\repos\\ShopProject\\ProductDatabase.sqlite";
        public static int c1 = 0;
        public static int c2 = 0;
        public static int c3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                DisplayProducts();
                foreach (Product p in Products)
                {
                    if (p.CategoryId == 0)
                    {
                        c1++;
                    }
                    else if (p.CategoryId == 1)
                    {
                        c2++;
                    }
                    else if (p.CategoryId == 2)
                    {
                        c3++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProducts()
        {
            const string query = "SELECT * FROM Product";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                var command = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["Id"].ToString());
                        string name = reader["Name"].ToString();
                        int units = int.Parse(reader["Units"].ToString());
                        double price = double.Parse(reader["Price"].ToString());
                        int catid = int.Parse(reader["CategoryId"].ToString());

                        Product product = new Product(id, name, units, price, catid);
                        Products.Add(product);
                    }
                }
            }
        }

        private void DeleteProduct(Product product)
        {
            const string query = "DELETE FROM Product WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", product.Id);

                command.ExecuteNonQuery();

                Products.Remove(product);
            }
        }

        private void DisplayProducts()
        {
            lvProducts.Items.Clear();
            Products.Sort();

            foreach (Product product in Products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name.ToString());
                item.SubItems.Add(product.Units.ToString());
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.CategoryId.ToString());

                item.Tag = product;

                lvProducts.Items.Add(item);
                lvProducts.Update();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Please select a product to delete. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete good from stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvProducts.SelectedItems[0];
                    Product product = (Product)selectedItem.Tag;

                    DeleteProduct(product);

                    DisplayProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing Implemented Yet!");
        }

        private void getTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Product product in Products)
            {
                total += (double)product;
            }
            MessageBox.Show("Total cost of the products is: " + total.ToString());
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            ChartForm chart = new ChartForm();
            chart.Show();
        }
    }
}
