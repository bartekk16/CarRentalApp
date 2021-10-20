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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //select * From TypeOfCars
            //var cars = _db.TypesOfCars.ToList();

            //Selec Id as CarId, name as CarName from TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new { CarId = q.Id, CarName = q.Make })
            //    .ToList();
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
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    Id = q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[0].HeaderText = "Marka";
            gvVehicleList.Columns[3].HeaderText = "Rok produkcji";
            gvVehicleList.Columns[4].HeaderText = "Numer Rejestracyjny";
            gvVehicleList.Columns[5].Visible = false;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                //launch
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                DialogResult dr = MessageBox.Show("Czy napewno chcesz usuńąć",
                    "Usuń", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //delete vehicle form table
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }
                PopulateGrid();
                               
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        
    }
}
