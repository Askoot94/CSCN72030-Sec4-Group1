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
        public TableA1ChefView()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            // 1st: Print "Ready" in textBox6
            textBox6.Text = "Ready";

            // 2nd: Print "Ready" in textBox4 of TableA1
            TableA1 tableA1Form = new TableA1();
            tableA1Form.UpdateTextBox4("Ready");

            // 3rd: Change text in label2 of Waiter_s_View to "A1!"
            Waiter_s_View waiterViewForm = new Waiter_s_View();
            waiterViewForm.UpdateLabel("A1!");

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
