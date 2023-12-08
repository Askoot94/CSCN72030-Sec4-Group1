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
    public partial class MainMenuA6 : Form
    {
       
        public string tableOrder;

        public MainMenuA6(string table)
        {
            InitializeComponent();

            tableOrder = table;
        }



        private void MainMenuA6_Load(object sender, EventArgs e)
        {
            label5.Text = tableOrder;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
