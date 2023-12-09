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
    public partial class TableB3ChefView : Form
    {
        public string Table { get; set; }
        public TableB3ChefView(string filename)
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

        private void guna2Button2_Click(object sender, EventArgs e) // back
        {
            Chef_s_View Chef = new Chef_s_View();
            Chef.Show();
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

        private Waiter_s_View Waiter_s_View = new Waiter_s_View();

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            textBox11.Text = "Ready";
            Waiter_s_View.UpdateLabelB3("B3!");
            Waiter_s_View.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Ready";
            Waiter_s_View.UpdateLabelB3("B3!");
            Waiter_s_View.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            textBox15.Text = "Ready";
            Waiter_s_View.UpdateLabelB3("B3!");
            Waiter_s_View.Show();
        }

        private void TableB3ChefView_Load(object sender, EventArgs e)
        {

        }
    }
}
