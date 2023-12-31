﻿using System;
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
    public partial class TableA4 : Form
    {
        public string filename { get; set; }
        public TableA4(string Table)
        {
            InitializeComponent();
            filename = Table;

        }

        private void TableA4_Load(object sender, EventArgs e)
        {
            Order file = new Order(filename);
            string buffer;
            if (file.GetNumberofDishes() >= 1)
            {
                buffer = file.GetDishQuantity(0).ToString();
                textBox4.Text = buffer;
                textBox5.Text = file.GetDishName(0);
            }
            if (file.GetNumberofDishes() >= 2)
            {
                buffer = file.GetDishQuantity(1).ToString();
                textBox8.Text = buffer;
                textBox9.Text = file.GetDishName(1);
            }
            if (file.GetNumberofDishes() >= 3)
            {
                buffer = file.GetDishQuantity(2).ToString();
                textBox12.Text = buffer;
                textBox13.Text = file.GetDishName(2);
            }

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

        private TableA4ChefView TableA4ChefView = new TableA4ChefView("Table A4");



        //private Waiter_s_View Waiter_s_View = new Waiter_s_View();
        private Chef_s_View Chef_s_View = new Chef_s_View();
        private void guna2CircleButton2_Click(object sender, EventArgs e) // Served button 2
        {
            textBox11.Text = ("Served");
            Chef_s_View.UpdateLabelA4("A4!");
            Chef_s_View.Show();
            TableA4ChefView.UpdateTextbox2("Served");
            TableA4ChefView.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) // Served button 1
        {
            textBox7.Text = ("Served");
            Chef_s_View.UpdateLabelA4("A4!");
            Chef_s_View.Show();

            TableA4ChefView.UpdateTextbox("Served");
            TableA4ChefView.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e) // Served button 3
        {
            textBox15.Text = ("Served");
            Chef_s_View.UpdateLabelA4("A4!");
            Chef_s_View.Show();
            TableA4ChefView.UpdateTextbox3("Served");
            TableA4ChefView.Show();
        }
    }
}
