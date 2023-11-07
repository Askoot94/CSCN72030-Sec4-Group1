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
    }
}
