using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Project_III_GUI
{
    public partial class MainMenuC2 : Form
    {
        public string tableOrder;

        public MainMenuC2(string table)
        {
            InitializeComponent();

            tableOrder = "Table C2";
        }



        private void MainMenuC2_Load(object sender, EventArgs e)
        {
            label5.Text = tableOrder;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e) // Back
        {
            Customer_s_View Customer = new Customer_s_View();
            Customer.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e) // Home
        {
            DialogResult iOpen;
            iOpen = MessageBox.Show("You want to go back to the login page?", "Ordering System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (iOpen == DialogResult.Yes)
            {
                LoginPage Home = new LoginPage();
                Home.Show();
                Visible = false;
            }
        }



        // Inside the current page class
        private Waiter_s_View Waiter_s_view = new Waiter_s_View();


        private void guna2Button19_Click(object sender, EventArgs e) // Order Status
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e) // Call server
        {
            Waiter_s_view.UpdateLabelC2("C2 !");
            Waiter_s_view.Show();
        }
    }
}
