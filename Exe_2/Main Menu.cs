using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_2
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataGridView().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BandingNavigation().Show();
            this.Hide();
        }
    }
}
