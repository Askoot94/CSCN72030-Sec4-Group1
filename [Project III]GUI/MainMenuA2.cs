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
    public partial class MainMenuA2 : Form
    {
        public string tableOrder;
        public MainMenuA2(string table)
        {
            InitializeComponent();

            tableOrder = "Table A2";
        }



        private void MainMenuA2_Load(object sender, EventArgs e)
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




        private void guna2Button19_Click(object sender, EventArgs e) // Order status
        {
            DialogResult iOpen;
            iOpen = MessageBox.Show("Request has been sent to the waiter to inform you the status of food... ", "Ordering System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (iOpen == DialogResult.OK)
            {

                Waiter_s_view.UpdateLabelA2("A2 !");
                Waiter_s_view.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) // Call server
        {
            Waiter_s_view.UpdateLabelA2("A2 !");
            Waiter_s_view.Show();
        }



        private int IncrementQuantity(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            int currentValue = int.Parse(textBox.Text);

            // Increment the value
            currentValue++;

            // Update the GunaTextBox with the new value
            textBox.Text = currentValue.ToString();

            return currentValue;
        }

        private int DecrementQuantity(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            int currentValue = int.Parse(textBox.Text);

            // Decrement the value, but ensure it doesn't go below 0
            currentValue = Math.Max(0, currentValue - 1);

            // Update the GunaTextBox with the new value
            textBox.Text = currentValue.ToString();

            return currentValue;
        }


        private string GetDescription(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            string description = textBox.Text;

            // Return the description
            return description;
        }

        private float GetPrice(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Try to parse the current value from the GunaTextBox
            float price;
            bool success = float.TryParse(textBox.Text, out price);

            // If the parse operation was not successful, handle the error
            if (!success)
            {
                // For example, you can set a default price
                price = 0.0f;
                // Or you can show an error message
                Console.WriteLine("Error: The price is not a valid number.");
            }

            // Return the price
            return price;
        }



        private void guna2Button18_Click(object sender, EventArgs e) // Send button
        {
            ProcessItem(TxtBox1, guna2TextBox2, guna2TextBox1);
            ProcessItem(TxtBox2, guna2TextBox5, guna2TextBox6);
            ProcessItem(TxtBox3, guna2TextBox8, guna2TextBox9);
            ProcessItem(TxtBox4, guna2TextBox11, guna2TextBox12);
            ProcessItem(TxtBox5, guna2TextBox14, guna2TextBox15);
            ProcessItem(TxtBox6, guna2TextBox17, guna2TextBox18);
            ProcessItem(TxtBox7, guna2TextBox20, guna2TextBox21);
            ProcessItem(TxtBox8, guna2TextBox23, guna2TextBox24);

            DialogResult iOpen;
            iOpen = MessageBox.Show("Your Order has been sent. ", "Ordering System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcessItem(Guna.UI2.WinForms.Guna2TextBox quantityTextBox, Guna.UI2.WinForms.Guna2TextBox descriptionTextBox, Guna.UI2.WinForms.Guna2TextBox priceTextBox)
        {
            Order orderFile = new Order(tableOrder);
            int quantity = int.Parse(quantityTextBox.Text);
            if (quantity > 0)
            {
                string description = GetDescription(descriptionTextBox);
                float price = GetPrice(priceTextBox);

                // Now you can use description, price, and quantity
                // For example, you can print them:
                orderFile.AddItem(description, price, quantity);
            }
            orderFile.SaveToFile();
        }

        private void ButtonPlus1_Click(object sender, EventArgs e) // Increase 1
        {
            IncrementQuantity(TxtBox1);         
        }

        private void ButtonMinus1_Click(object sender, EventArgs e) // Decrease 1
        {
            DecrementQuantity(TxtBox1);
        }

        private void ButtonPlus2_Click(object sender, EventArgs e) // Increase 2
        {
            IncrementQuantity(TxtBox2);
        }

        private void ButtonMinus2_Click(object sender, EventArgs e) // Decrease 2
        {
            DecrementQuantity(TxtBox2);

        }

        private void ButtonPlus3_Click(object sender, EventArgs e) // Increase 3
        {
            IncrementQuantity(TxtBox3);

        }

        private void ButtonMinus3_Click(object sender, EventArgs e) // Decrease 3
        {
            DecrementQuantity(TxtBox3);

        }

        private void ButtonPlus4_Click(object sender, EventArgs e) // Increase 4
        {
            IncrementQuantity(TxtBox4);

        }

        private void ButtomMinus4_Click(object sender, EventArgs e) // Decrease 4
        {
            DecrementQuantity(TxtBox4);

        }

        private void ButtonPlus5_Click(object sender, EventArgs e) // Increase 5
        {
            IncrementQuantity(TxtBox5);

        }

        private void ButtonMinus5_Click(object sender, EventArgs e) // Decrease 5
        {
            DecrementQuantity(TxtBox5);

        }

        private void ButtonPlus6_Click(object sender, EventArgs e) // Increase 6
        {
            IncrementQuantity(TxtBox6);

        }

        private void ButtonMinus6_Click(object sender, EventArgs e) // Decrease 6
        {
            DecrementQuantity(TxtBox6);

        }

        private void ButtonPlus7_Click(object sender, EventArgs e) // Increase 7
        {
            IncrementQuantity(TxtBox7);

        }

        private void ButtonMinus7_Click(object sender, EventArgs e) // Decrease 7
        {
            DecrementQuantity(TxtBox7);

        }

        private void ButtonPlus8_Click(object sender, EventArgs e) // Increase 8
        {
            IncrementQuantity(TxtBox8);

        }

        private void ButtonMinus8_Click(object sender, EventArgs e) // Decrease 8
        {
            DecrementQuantity(TxtBox8);

        }
    }
}
