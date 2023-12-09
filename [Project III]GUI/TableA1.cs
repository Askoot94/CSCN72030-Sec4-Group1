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
    public partial class TableA1 : Form
    {
        public string filename { get; set; }
        public TableA1(string Table)
        {
            InitializeComponent();
            filename = Table;
            
        }

        private void TableA1_Load(object sender, EventArgs e)
        {
            FetchDisplayData(0);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e) // back butonn
        {
            Waiter_s_View Waiter = new Waiter_s_View();
            Waiter.Show();
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTextbox(string newText)
        {
            textBox7.Text = newText;
        }

        private TableA1ChefView TableA1ChefView = new TableA1ChefView("TableA1");
        //private Waiter_s_View Waiter_s_View = new Waiter_s_View();
        private Chef_s_View Chef_s_View = new Chef_s_View();
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            textBox7.Text = ("Served");
            Chef_s_View.UpdateLabel("A1!");
            Chef_s_View.Show();
          
            TableA1ChefView.UpdateTextbox("Served");
            TableA1ChefView.Show();
            
            
        }

        private void FetchDisplayData(int page)
        {
            Order file = new Order(filename);
            string buffer;
            int Additive = (page * 3);
            if (file.GetNumberofDishes() >= 1 + Additive)
            {
                buffer = file.GetDishQuantity(0 + Additive).ToString();
                textBox4.Text = buffer;
                textBox5.Text = file.GetDishName(0);
            }
            if (file.GetNumberofDishes() >= 2 + Additive)
            {
                buffer = file.GetDishQuantity(1 + Additive).ToString();
                textBox8.Text = buffer;
                textBox9.Text = file.GetDishName(1 + Additive);
            }
            if (file.GetNumberofDishes() >= 3 + Additive)
            {
                buffer = file.GetDishQuantity(2 + Additive).ToString();
                textBox12.Text = buffer;
                textBox13.Text = file.GetDishName(2 + Additive);
            }
            return;
        }
    }
}
