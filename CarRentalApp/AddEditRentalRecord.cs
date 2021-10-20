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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private ManageRentalRecords _manageRentalRecords;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord(ManageRentalRecords manageRentalRecords=null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _manageRentalRecords = manageRentalRecords;
            _db = new CarRentalEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecords manageRentalRecords=null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            _manageRentalRecords = manageRentalRecords;
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                //var cost = tbCost.Text;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage +="Error: Please enter missing data";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection";
                }

                if (isValid == true)
                {
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateOut;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    if (!isEditMode)
                        _db.CarRentalRecords.Add(rentalRecord);

                    _db.SaveChanges();

                     MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                      $"Date Rented: {dateOut}\n\r" +
                                      $"Date Returned: {dateIn}\n\r" +
                                      $"Cost: {cost}\n\r" +
                                      $"Car Type: {carType}\n\r");
                    _manageRentalRecords.PopulateGrid();
                    MessageBox.Show("Updated");
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        private void AddEditRentalRecord_Load(object sender, EventArgs e)
        {
            //Select * form TypesOfCars 
            //var cars = _db.TypesOfCars.ToList();
            var cars = _db.TypesOfCars
               .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model })
               .ToList();

            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }
    }
}
