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
    public partial class TableB2 : Form
    {
        Order tableOrder = new Order("TableB2");
        public TableB2()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e) // back
        {
            Waiter_s_View Waiter = new Waiter_s_View();
            Waiter.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e) // home
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
        //private Waiter_s_View Waiter_s_View = new Waiter_s_View();
        private Chef_s_View Chef_s_View = new Chef_s_View();
        private void guna2CircleButton2_Click(object sender, EventArgs e) // Served button 2
        {
            textBox11.Text = ("Served");
            Chef_s_View.UpdateLabel("B2 !");
            Chef_s_View.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) // Served button 1
        {
            textBox7.Text = ("Served");
            Chef_s_View.UpdateLabel("B2 !");
            Chef_s_View.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e) // Served button 3
        {
            textBox15.Text = ("Served");
            Chef_s_View.UpdateLabel("B2 !");
            Chef_s_View.Show();
        }
    }
}
