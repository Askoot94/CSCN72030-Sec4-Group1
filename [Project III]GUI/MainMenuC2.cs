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

            tableOrder = table;
        }



        private void MainMenuC2_Load(object sender, EventArgs e)
        {
            label5.Text = tableOrder;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
