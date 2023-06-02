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
using System.Data.SQLite;

namespace Project_version_7
{
    public partial class GoodsStockForm : Form
    {
        public GoodsStockForm()
        {
            InitializeComponent();
        }

        private const string ConnectionString = "Data Source=C:\\Users\\Bogdan\\source\\repos\\Project_version_7\\Stock.sqlite";
        private readonly List<Good> _goods = new List<Good>();

        private void DisplayGoods()
        {
            lvGoods.Items.Clear();

            foreach (Good good in _goods)
            {
                ListViewItem listViewItem = new ListViewItem(good.Id.ToString());
                listViewItem.SubItems.Add(good.Name.ToString());
                listViewItem.SubItems.Add(good.Quantity.ToString());
                listViewItem.SubItems.Add(good.SupplierId.ToString());

                listViewItem.Tag = good;

                lvGoods.Items.Add(listViewItem);
                lvGoods.Update();
            }
        }

        private void AddGood(Good good)
        {
            var query = "insert into Good(Name, Quantity, SupplierId)" +
                                " values(@name,@quantity,@supplierId);  " +
                                "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", good.Name);
                command.Parameters.AddWithValue("@quantity", good.Quantity);
                command.Parameters.AddWithValue("@supplierId", good.SupplierId);

                good.Id = (long)command.ExecuteScalar();

                _goods.Add(good);
            }
        }

        private void GoodsStockForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGoods();
                DisplayGoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var quantity = nudQuantity.Value;
            var supplierId = nudSupplierId.Value;

            var good = new Good(name, (int)quantity, (int)supplierId);

            try
            {
                AddGood(good);
                DisplayGoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Good> Get_goods()
        {
            return _goods;
        }

        private void LoadGoods()
        {
            const string query = "SELECT * FROM Good";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["ID"];
                        string name = (string)reader["Name"];
                        long quantity = (long)reader["Quantity"];
                        long supplierId = (long)reader["SupplierId"];

                        Good good = new Good(id, name, quantity, supplierId);
                        _goods.Add(good);
                    }
                }
            }
        }

        private void DeleteGood(Good good)
        {
            const string query = "DELETE FROM Good WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", good.Id);

                command.ExecuteNonQuery();

                _goods.Remove(good);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvGoods.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Select a good to delete. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete good from stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvGoods.SelectedItems[0];
                    Good good = (Good)selectedItem.Tag;

                    DeleteGood(good);

                    DisplayGoods();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string ViewGood(Good good)
        {
            const string query = "SELECT * FROM Good WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", good.Id);

                command.ExecuteNonQuery();
            }
            return query;
        }

        private void lvGoods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lvGoods.SelectedItems[0].ToString());
        }

        private void lvGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGoods.SelectedItems.Count == 1)
            {
                int index = lvGoods.SelectedItems[0].Index;
                tbName.Text = lvGoods.Items[index].SubItems[1].Text;
                nudQuantity.Value = Convert.ToInt32(lvGoods.Items[index].SubItems[2].Text);
                nudSupplierId.Value = Convert.ToInt32(lvGoods.Items[index].SubItems[3].Text);
            }
        }

        private void UpdateGood(Good good)
        {/*
            const string query = "UPDATE Good SET Name=@name, Quantity=@quantity, SupplierId=@supplierId WHERE Id=@id";
            //const string query2 = "DELETE FROM Good WHERE Id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var x = good.Id + 1;
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", x);
                command.Parameters.AddWithValue("@name", tbName.Name);
                command.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                command.Parameters.AddWithValue("@supplierId", nudSupplierId.Value);
                //
                //SQLiteCommand command2 = new SQLiteCommand(query2, connection);
                //command.Parameters.AddWithValue("@id", good.Id);

                //command2.ExecuteNonQuery();

                //_goods.Remove(good);

                //good.Id = (long)command.ExecuteScalar();

                _goods.Add(good);
            } */
            var query = "insert into Good(Name, Quantity, SupplierId)" +
                                " values(@name,@quantity,@supplierId);  " +
                                "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", tbName.Name);
                command.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                command.Parameters.AddWithValue("@supplierId", nudSupplierId.Value);

                //good.Id = (long)command.ExecuteScalar();

                _goods.Add(good);
            }
            /*
            query = "DELETE FROM Good WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", good.Id);

                command.ExecuteNonQuery();

                _goods.Remove(good);
            }*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvGoods.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Select a good to update. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (lvGoods.SelectedItems.Count == 1)
            {
                try
                {
                    ListViewItem selectedItem = lvGoods.SelectedItems[0];
                    Good good = (Good)selectedItem.Tag;

                    if (MessageBox.Show("Are you sure?", "Update good from stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                    {
                        UpdateGood(good);
                        DisplayGoods();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
