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

namespace ReservationsExam2023
{
    public partial class AddRezervationForm : Form
    {
        private Reservation ReservationAux = new Reservation();
        private List<Reservation> Reservations = new List<Reservation>();
        public AddRezervationForm(Reservation reservation)
        {
            ReservationAux = reservation;
            InitializeComponent();
            nudId.Value = reservation.Id;
            nudPersons.Value = reservation.Persons;
        }

        private void AddRezervationForm_Load(object sender, EventArgs e)
        {
            string[] data = System.IO.File.ReadAllLines("RoomsData.txt");
            foreach (string line in data)
            {
                lbRoom.Items.Add(line);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReservationAux.Id = (int)nudId.Value;
            ReservationAux.RoomId = lbRoom.SelectedIndex;
            ReservationAux.CheckInDate = dtpCheckIn.Value;
            ReservationAux.CheckOutDate = dtpCheckOut.Value;
            ReservationAux.Persons = (int)nudPersons.Value;

            Reservations.Add(ReservationAux);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpCheckOut_Validating(object sender, CancelEventArgs e)
        {
            if (dtpCheckIn.Value > dtpCheckOut.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Check Out date cannot be befor check in!");
            }
        }

        private void dtpCheckOut_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpCheckOut, null);
        }
    }
}
