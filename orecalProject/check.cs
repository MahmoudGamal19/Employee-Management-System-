using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orecalProject
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddHR a = new AddHR();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddHR2 a2 = new AddHR2();
            a2.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddHR2 ad = new AddHR2();
            ad.Show();
            this.Close();
        }
    }
}
