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
    public partial class AddProductForm : Form
    {
        private List<string> Categories = new List<string>();
        private List<Product> Products = new List<Product>();
        private const string ConnectionString = "Data Source=C:\\Users\\Bogdan\\source\\repos\\ShopProject\\ProductDatabase.sqlite";
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            string[] content = System.IO.File.ReadAllLines("Categories.txt");
            foreach (string line in content)
            {
                Categories.Add(line);
                cbCategory.Items.Add(line);
            }
        }

        private void addProduct(Product product)
        {
            string query = "INSERT INTO Product(Id, Name, Units, Price, CategoryId)" +
                "VALUES (@id, @name, @units, @price, @idcat); " +
                "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@units", product.Units);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@idcat", product.CategoryId);

                command.ExecuteNonQuery();

                Products.Add(product);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = tbId.Text;
            var name = tbName.Text;
            var units = tbUnits.Text;
            var price = tbPrice.Text;
            int index = cbCategory.SelectedIndex;
            var catid = Categories.ElementAt(index);

            Product product = new Product(int.Parse(id), name.ToString(), int.Parse(units), double.Parse(price), index);

            try
            {
                addProduct(product);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (tbId.Text == "") { }
            else if (!int.TryParse(tbId.Text, out i))
            {
                tbId.Clear();
                MessageBox.Show("Non numeric value was introduced!");
            }
            if (i < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Id must be a pozitive integer!");
            }
        }

        private void tbId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbId, null);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            // no validation needed
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            // validated by default
        }

        private void tbUnits_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (tbUnits.Text == "") { }
            else if (!int.TryParse(tbUnits.Text, out i))
            {
                tbUnits.Clear();
                MessageBox.Show("Non numeric value was introduced!");
            }
            if (i < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Number of units must be a pozitive integer!");
            }
        }

        private void tbUnits_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUnits, null);
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            double i = 0;
            if (tbPrice.Text == "") { }
            else if (!double.TryParse(tbPrice.Text, out i))
            {
                tbPrice.Clear();
                MessageBox.Show("Non numeric value was introduced!");
            }
            if (i < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Price must be a pozitive double!");
            }
        }

        private void tbPrice_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPrice, null);
        }

        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategory ==  null)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Select a category");
            }
        }

        private void cbCategory_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbCategory, null);
        }
    }
}
