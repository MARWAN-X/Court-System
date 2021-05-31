using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Court_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cases_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            this.Hide();
            casesForm.Show();
        }

        private void btn_Judges_Click(object sender, EventArgs e)
        {
            Judges judgesForm = new Judges();
            this.Hide();
            judgesForm.Show();
        }

        private void btn_court_Click(object sender, EventArgs e)
        {
            Court courtForm = new Court();
            this.Hide();
            courtForm.Show();
        }
    }
}
