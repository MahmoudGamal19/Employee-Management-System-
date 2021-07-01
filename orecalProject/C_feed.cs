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
    public partial class C_feed : Form
    {
        int id = 0;
        int d = 0;
        public C_feed(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id <= 3000)
            {
                EMPLOYE E = new EMPLOYE(id,d);
                E.Show();
                this.Close();
            }
            else
            {
                HR h = new HR(id,d);
                h.Show();
                this.Close();

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void F_N_Click(object sender, EventArgs e)
        {
            F_N.Text = "";
        }

        private void C_feed_Load(object sender, EventArgs e)
        {

        }
    }
}
