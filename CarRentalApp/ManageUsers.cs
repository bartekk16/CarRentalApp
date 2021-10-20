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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var hashed_password = Utils.DefaultHashPassword();
                user.password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"Hasło użytkonika {user.username} zostało zresetowane");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                //aktywny dezaktywuje nieaktywny aktywuje null aktywuje
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"Stastuj aktywnosci użytkownika {user.username} został zmieniony");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var users = _db.Users.Select(q => new
            {
                q.id,
                q.username,
                q.UserRoles.FirstOrDefault().Role.name,
                q.isActive
            }).ToList();

            gvUserList.DataSource = users;
            gvUserList.Columns["username"].HeaderText = "Nazwa użytkownika";
            gvUserList.Columns["name"].HeaderText = "Uprawnienia";
            gvUserList.Columns["isActive"].HeaderText = "Czy aktywny";
            gvUserList.Columns["Id"].Visible = false;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
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
    }
}
