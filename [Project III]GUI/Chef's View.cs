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
    public partial class Chef_s_View : Form
    {
        public Chef_s_View()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TableA1ChefView tablea1 = new TableA1ChefView();
            tablea1.Show();
            Visible = false;
        }
    }
}

