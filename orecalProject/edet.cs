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
    public partial class edet : Form
    {
        int id = 0;
        int d = 0;
        public edet(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id <= 3000)
            {
                EMPLOYE E = new EMPLOYE(id,d);
                E.Show();
                this.Close();
            }
            else {
                HR h = new HR(id,d);
                h.Show();
                this.Close();

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("this Name can not Edited ", "Edite", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {


            MessageBox.Show("this Name can not Edited ", "Edite", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void textBox3_Click(object sender, EventArgs e)
        {


            MessageBox.Show("this Name can not Edited ", "Edite", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
 