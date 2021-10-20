using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord(this);
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //launch
                var addEditRentalRecord = new AddEditRentalRecord(record, this);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //delete vehicle form table
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["Customer"].HeaderText = "Imię i Nazwisko klienta";
            gvRecordList.Columns["Cost"].HeaderText = "Cena";
            gvRecordList.Columns["DateIn"].HeaderText = "Data wypożyczenia";
            gvRecordList.Columns["DateOut"].HeaderText = "Data zwrotu";
            gvRecordList.Columns["Car"].HeaderText = "Samochód";
            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
