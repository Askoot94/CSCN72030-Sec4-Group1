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
            DialogResult iOpen;
            iOpen = MessageBox.Show("Request has been sent to the waiter to inform you the status of food... ", "Ordering System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (iOpen == DialogResult.OK)
            {

                Waiter_s_view.UpdateLabelC2("C2 !");
                Waiter_s_view.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) // Call server
        {
            Waiter_s_view.UpdateLabelC2("C2 !");
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

        private void ButtonMinus1_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox1);

        }

        private void ButtonMinus2_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox2);

        }

        private void ButtonMinus3_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox3);

        }

        private void ButtomMinus4_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox4);

        }

        private void ButtonMinus5_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox5);

        }

        private void ButtonMinus6_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox6);

        }

        private void ButtonMinus7_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox7);

        }
        private void ButtonMinus8_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox8);


        }
        private void MainMenuC2_Load_1(object sender, EventArgs e)
        {
        }

     

        private void ButtonPlus1_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox1);

        }

        private void ButtonPlus2_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox2);

        }

        private void ButtonPlus3_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);

        }
        private void ButtonPlus4_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);


        }
        private void ButtonPlus5_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);

        }

        private void ButtonPlus6_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);

        }

        private void ButtonPlus7_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);

        }

        private void ButtonPlus8_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox8);

        }
    }
}
