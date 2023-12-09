using _Project_III_GUI;
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
    public partial class Customer_s_View : Form
    {
        public Customer_s_View()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e) // back button
        {
            LoginPage Home = new LoginPage();
            Home.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e) // home button
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

        private void label2_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("Table A1");
            Mainmenu.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainMenuA2 Mainmenu = new MainMenuA2("Table A2");
            Mainmenu.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainMenuA3 MainMenu = new MainMenuA3("Table A3");
            MainMenu.Show();
            Visible = false;
        }
       
        private void label6_Click(object sender, EventArgs e) // B1
        {
            MainMenuB1 Mainmenu = new MainMenuB1("Table B1");
            Mainmenu.Show();
            Visible = false;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            MainMenuC1 Mainmenu = new MainMenuC1("Table C1");
            Mainmenu.Show();
            Visible = false;
        }
        private void label8_Click(object sender, EventArgs e) // A5
        {
            MainMenuA5 Mainmenu = new MainMenuA5("Table A5");
            Mainmenu.Show();
            Visible = false;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            MainMenuB2 Mainmenu = new MainMenuB2("Table B2");
            Mainmenu.Show();
            Visible = false;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            MainMenuC2 Mainmenu = new MainMenuC2("Table C2");
            Mainmenu.Show();
            Visible = false;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            MainMenuA6 Mainmenu = new MainMenuA6("Table A6");
            Mainmenu.Show();
            Visible = false;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            MainMenuB3 Mainmenu = new MainMenuB3("Table B3");
            Mainmenu.Show();
            Visible = false;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            MainMenuC3 Mainmenu = new MainMenuC3("Table C3");
            Mainmenu.Show();
            Visible = false;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MainMenuA4 Mainmenu = new MainMenuA4("Table A4");
            Mainmenu.Show();
            Visible = false;
        }
    }
}
