using Project_version_7.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_version_7
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private const string ConnectionString = "Data Source=C:\\Users\\Bogdan\\source\\repos\\Project_version_7\\Stock.sqlite";
        private readonly List<Supplier> _suppliers = new List<Supplier>();

        private void DisplaySuppliers()
        {
            lvSuppliers.Items.Clear();

            foreach (Supplier supplier in _suppliers)
            {
                ListViewItem listViewItem = new ListViewItem(supplier.Id.ToString());
                listViewItem.SubItems.Add(supplier.Name.ToString());
                listViewItem.SubItems.Add(supplier.Email.ToString());

                listViewItem.Tag = supplier;

                lvSuppliers.Items.Add(listViewItem);
                lvSuppliers.Update();
            }
        }

        private void AddSupplier(Supplier supplier)
        {
            var query = "insert into Supplier(Name, Email)" +
                                " values(@name,@email);  " +
                                "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", supplier.Name);
                command.Parameters.AddWithValue("@email", supplier.Email);

                supplier.Id = (long)command.ExecuteScalar();

                _suppliers.Add(supplier);
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSuppliers();
                DisplaySuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var email = tbEmail.Text;

            var supplier = new Supplier(name, email);

            try
            {
                AddSupplier(supplier);
                DisplaySuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Supplier> Get_Suppliers()
        {
            return _suppliers;
        }

        private void LoadSuppliers()
        {
            const string query = "SELECT * FROM Supplier";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string name = (string)reader["Name"];
                        string email = (string)reader["Email"];

                        Supplier supplier = new Supplier(id, name, email);
                        _suppliers.Add(supplier);
                    }
                }
            }
        }

        private void DeleteSupplier(Supplier supplier)
        {
            const string query = "DELETE FROM Supplier WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", supplier.Id);

                command.ExecuteNonQuery();

                _suppliers.Remove(supplier);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvSuppliers.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Select a supplier to delete. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvSuppliers.SelectedItems[0];
                    Supplier supplier = (Supplier)selectedItem.Tag;

                    DeleteSupplier(supplier);

                    DisplaySuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string ViewSupplier(Supplier supplier)
        {
            const string query = "SELECT * FROM Supplier WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", supplier.Id);

                command.ExecuteNonQuery();
            }
            return query;
        }

        private void lvSuppliers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lvSuppliers.SelectedItems[0].ToString());
        }

        private void lvSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}