using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace _Project_III_GUI
{
    public partial class OrderCart : Form
    {

        private MainMenu _mainMenu;
        public OrderCart()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cartItems = _mainMenu.CartItems;

            //cartItems.ForEach(item =>
            //{
            //    string itemText = $"{item.ProductName} x {item.Quantity}";
            //    cartItemListBox.Items.Add(itemText);
            //});

            //if (cartItems.count = 0)
            //{
            //    guna2Button1.Enabled = false;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("Your order has been sent.");
            //if (dr == DialogResult.OK)
            //{
            //    _mainMenu.ClearCart();
            //    this.Close();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
