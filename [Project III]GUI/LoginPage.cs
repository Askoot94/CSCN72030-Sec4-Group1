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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e) 
        {
        }

        private void label5_Click(object sender, EventArgs e) // Chef label
        {

        }

        private void label6_Click(object sender, EventArgs e) // Waiter label
        {
            Waiter_s_View waiter = new Waiter_s_View();
            waiter.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e) // Customer label
        {
            OrderCart orderCart = new OrderCart();
            orderCart.Show();
            Visible = false;
        }

        private void label4_Click_1(object sender, EventArgs e) // Exit label
        {
            DialogResult iExit;
            iExit = MessageBox.Show("You want to exit the system",
                "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Restaurantname_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e) // Chef label
        {
            
        }

        private void label7_Click_1(object sender, EventArgs e) // Waiter label
        {
            DialogResult iOpen;
            iOpen = MessageBox.Show("Continue as a Waiter?",
                "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iOpen == DialogResult.Yes)
            {
                Waiter_s_View waiter = new Waiter_s_View();
                waiter.Show();
                Visible = false;
            }
        }
    }
}
