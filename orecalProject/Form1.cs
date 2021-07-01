using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace orecalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_HM_Click(object sender, EventArgs e)
        {
            Login log = new Login(1);
            log.Show();
            Visible = false;

        }

        private void B_E_Click(object sender, EventArgs e)
        {
            Login log = new Login(3);
            log.Show();
            Visible = false;

         
        }

        private void B_HR_Click(object sender, EventArgs e)
        {
            Login log = new Login(2);
            log.Show();
            Visible = false;
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
