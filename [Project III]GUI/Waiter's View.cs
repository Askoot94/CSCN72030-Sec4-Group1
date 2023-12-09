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
    public partial class Waiter_s_View : Form
    {
        public Waiter_s_View()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e) // A5
        {
            TableA5 tablea5 = new TableA5("Table A5");
            tablea5.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) // A4
        {
            TableA4 tablea4 = new TableA4("Table A4");
            tablea4.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e) // Table A1 
        {
            TableA1 tablea1 = new TableA1("Table A1");
            tablea1.Show();
            Visible = false;
        } 

        private void label3_Click(object sender, EventArgs e) // Table A2
        {
            TableA2 tablea2 = new TableA2("Table A2");
            tablea2.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e) // Table A3
        {
            TableA3 tablea3 = new TableA3("Table A3");
            tablea3.Show();
            Visible = false;

        }

        private void label6_Click(object sender, EventArgs e) // B1
        {
            TableB1 tableB1 = new TableB1("Table B1");
            tableB1.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TableC1 tableC1 = new TableC1("Table C1");
            tableC1.Show();
            Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TableB2 tableB2 = new TableB2("Table B2");
            tableB2.Show();
            Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            TableC2 tableC2 = new TableC2("Table C2");
            tableC2.Show();
            Visible = false;
        }

        private void label11_Click(object sender, EventArgs e) // A6
        {
            TableA6 tablea6 = new TableA6("Table A6");
            tablea6.Show();
            Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            TableB3 tableB3 = new TableB3("Table B3");
            tableB3.Show();
            Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

            TableC3 tableC3 = new TableC3("Table C3");
            tableC3.Show();
            Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e) // Back button
        {
            LoginPage Home = new LoginPage();
            Home.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e) // Home button
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

        public void UpdateLabel(string newText)
        {
            label2.Text = newText;
        }

        public void UpdateLabelA2(string newText)
        {
            label3.Text = newText;
        }

        public void UpdateLabelA3(string newText)
        {
            label4.Text = newText;
        }

        public void UpdateLabelA4(string newText)
        {
            label5.Text = newText;
        }

        public void UpdateLabelA5(string newText)
        {
            label8.Text = newText;
        }

        public void UpdateLabelA6(string newText)
        {
            label11.Text = newText;
        }

        public void UpdateLabelB1(string newText)
        {
            label6.Text = newText;
        }

        public void UpdateLabelB2(string newText)
        {
            label9.Text = newText;
        }

        public void UpdateLabelB3(string newText)
        {
            label12.Text = newText;
        }

        public void UpdateLabelC1(string newText)
        {
            label7.Text = newText;
        }

        public void UpdateLabelC2(string newText)
        {
            label10.Text = newText;
        }

        public void UpdateLabelC3(string newText)
        {
            label13.Text = newText;
        }

    }
}
