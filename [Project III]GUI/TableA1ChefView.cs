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
    public partial class TableA1ChefView : Form
    {
        public string Table { get; set; }
        public TableA1ChefView(string filename)
        {
            InitializeComponent();
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            Table = filename;
            Order file = new Order(filename);
            if (file.GetNumberofDishes() == 1)
            {
                string buffer;
                buffer = file.GetDishQuantity(0).ToString();
                textBox4.Text = buffer;
                textBox5.Text = file.GetDishName(0);
            }
            else if (file.GetNumberofDishes() == 2)
            {
                string buffer;
                buffer = file.GetDishQuantity(0).ToString();
                textBox4.Text = buffer;
                textBox5.Text = file.GetDishName(0);

                buffer = file.GetDishQuantity(1).ToString();
                textBox8.Text = buffer;
                textBox9.Text = file.GetDishName(1);
            }
            else if (file.GetNumberofDishes() == 3)
            {
                string buffer;
                buffer = file.GetDishQuantity(0).ToString();
                textBox4.Text = buffer;
                textBox5.Text = file.GetDishName(0);

                buffer = file.GetDishQuantity(1).ToString();
                textBox8.Text = buffer;
                textBox9.Text = file.GetDishName(1);

                buffer = file.GetDishQuantity(2).ToString();
                textBox12.Text = buffer;
                textBox13.Text = file.GetDishName(2);
            }
            else
            {
                return;
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e) // Back button
        {
            Chef_s_View Chef = new Chef_s_View();
            Chef.Show();
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


     

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e) // Ready button 3
        {
            textBox15.Text = "Ready";
            Waiter_s_View.UpdateLabel("A1!");
            Waiter_s_View.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e) // Ready button 2
        {
            textBox11.Text = "Ready";
            Waiter_s_View.UpdateLabel("A1!");
            Waiter_s_View.Show();
        }

        //private TableA1 TableA1 = new TableA1();
        private Waiter_s_View Waiter_s_View = new Waiter_s_View();
        private void guna2CircleButton1_Click(object sender, EventArgs e) // Ready Button 1
        {
            textBox7.Text = "Ready";
            Waiter_s_View.UpdateLabel("A1!");
            Waiter_s_View.Show();

            //TableA1.UpdateTextbox("Ready");
            //TableA1.Show();

        }
        public void UpdateTextbox(string newText) // Update Textbox 1
        {
            textBox7.Text = newText;
        }

        public void UpdateTextbox2(string newText) // Update Textbox 2
        {
            textBox11.Text = newText;
        }

        public void UpdateTextbox3(string newText) // Update Textbox 3
        {
            textBox15.Text = newText;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) // status 1
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e) // status 2
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e) // status 3
        {

        }
    }
}

