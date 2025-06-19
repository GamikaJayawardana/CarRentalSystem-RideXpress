using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem_RideXpress
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //dashboard1.Visible = true;
            //issueCar1.Visible = false;
            //addCars1.Visible = false;
            //returnCar1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // User chose not to logout
            }
            else if (result == DialogResult.Yes)
            {
                // Perform logout actions
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            //dashboard1.Visible = false;
            //issueCar1.Visible = false;
            //addCars1.Visible = true;
            //returnCar1.Visible = false;
        }

        private void btnIssueCar_Click(object sender, EventArgs e)
        {
            //dashboard1.Visible = false;
            //issueCar1.Visible = true;
            //addCars1.Visible = false;
            //returnCar1.Visible = false;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            //dashboard1.Visible = false;
            //issueCar1.Visible = false;
            //addCars1.Visible = false;
            //returnCar1.Visible = true;
        }
    }
}
