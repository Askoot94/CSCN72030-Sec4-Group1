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
    public partial class TableA2 : Form
    {
        public TableA2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }


        // Function to set the visibility of a box in the TableLayoutPanel
        private void SetBoxVisibility(int row, int column, bool isVisible)
        {
            Control box = tableLayoutPanel2.GetControlFromPosition(column, row);

            if (box != null)
            {
                box.Visible = isVisible;
            }
        }

        private void ExampleUsage()
        {
            SetBoxVisibility(0, 1, true);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



