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
using System.IO;
using System.Xml.Serialization;

namespace ReservationsExam2023
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=C:\\Users\\Bogdan\\source\\repos\\ReservationsExam2023\\Database.sqlite";
        List<Reservation> Reservations = new List<Reservation>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // LoadData();
                Reservations = LoadData();
                DisplayReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Load data with SQLite Database
        /* 
        private void LoadData()
        {
            const string query = "SELECT * FROM Reservation";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["Id"].ToString());
                        int roomId = int.Parse(reader["RoomId"].ToString());
                        DateTime checkIn = DateTime.ParseExact(reader["CheckIn"].ToString().Trim(), "dd/MM/yyyy", null);
                        DateTime checkOut = DateTime.ParseExact(reader["CheckOut"].ToString().Trim(), "dd/MM/yyyy", null);
                        int persons = int.Parse(reader["Persons"].ToString());

                        Reservation reservation = new Reservation(id, roomId, checkIn, checkOut, persons);
                        Reservations.Add(reservation);
                    }
                }
            }
        }
        */

        // Load data from a XML file
        private List<Reservation> LoadData()
        {
            List<Reservation> list = new List<Reservation>();

            if (File.Exists("Database.xml") == true)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Reservation>));
                using (FileStream f = new FileStream("Database.xml", FileMode.Open))
                {
                    list = (List<Reservation>)xmlSerializer.Deserialize(f);
                }
            }
            return list;
        }

        private void DisplayReservations()
        {
            lvRezervation.Items.Clear();
            //Reservations.Sort();

            foreach (Reservation reservation in Reservations)
            {
                ListViewItem item = new ListViewItem(reservation.Id.ToString());
                item.SubItems.Add(reservation.RoomId.ToString());
                item.SubItems.Add(reservation.CheckInDate.ToString());
                item.SubItems.Add(reservation.CheckOutDate.ToString());
                item.SubItems.Add(reservation.Persons.ToString());
                
                item.Tag = reservation;

                lvRezervation.Items.Add(item);
            }
        }

        private void btnEnterRez_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            AddRezervationForm form = new AddRezervationForm(reservation);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Reservations.Add(reservation);
                DisplayReservations();
            }
        }

        // ! Update button will duplicate the modified entry (invokes List.add in AddReservationForm)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvRezervation.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Please select a reservation to update. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ListViewItem selectedItem = lvRezervation.SelectedItems[0];
                Reservation reservation = (Reservation)selectedItem.Tag;
                AddRezervationForm form = new AddRezervationForm(reservation);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Reservations.Add(reservation);
                    DisplayReservations();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvRezervation.SelectedItems.Count == 0)
            {
                MessageBox.Show("\t Please select a reservation to delete. \t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure?", "Delete reservation from database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvRezervation.SelectedItems[0];
                    Reservation reservation = (Reservation)selectedItem.Tag;

                    Reservations.Remove(reservation);
                    DisplayReservations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsbSerializeToXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Reservation>));
            using (FileStream f = new FileStream("Database.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(f, Reservations);
            }
            MessageBox.Show("The data has been saved!");
        }
    }
}
