﻿using _Project_III_GUI;
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
    
    public partial class Chef_s_View : Form
    {
        
        public Chef_s_View()
        {
            InitializeComponent();
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









        private void label2_Click(object sender, EventArgs e)
        {
            TableA1ChefView tablea1 = new TableA1ChefView("Table A1");
            tablea1.Show();
            Visible = false;
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

        private void label3_Click(object sender, EventArgs e)
        {
            TableA2ChefView tablea2 = new TableA2ChefView("Table A2");
            tablea2.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TableA3ChefView tablea3 = new TableA3ChefView("Table A3");
            tablea3.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TableA4ChefView tablea4 = new TableA4ChefView("Table A4");
            tablea4.Show();
            Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TableA5ChefView tablea5 = new TableA5ChefView("Table A5");
            tablea5.Show();
            Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            TableA6ChefView tablea6 = new TableA6ChefView("Table A6");
            tablea6.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TableB1ChefView tableb1 = new TableB1ChefView("Table B1");
            tableb1.Show();
            Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TableB2ChefView tableb2 = new TableB2ChefView("Table B2");
            tableb2.Show();
            Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            TableB3ChefView tableb3 = new TableB3ChefView("Table B3");
            tableb3.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TableC1ChefView tablec1 = new TableC1ChefView("Table C1");
            tablec1.Show();
            Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            TableC2ChefView tablec2 = new TableC2ChefView("Table C2");
            tablec2.Show();
            Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            TableC3ChefView tablec3 = new TableC3ChefView("Table C3");
            tablec3.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

