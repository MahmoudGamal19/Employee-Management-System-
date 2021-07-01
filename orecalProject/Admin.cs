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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void V_E_Click(object sender, EventArgs e)
        {
            V_Emp V = new V_Emp();
            V.Show();
            this.Close();
 
            
        }

        private void HR_Click(object sender, EventArgs e)
        {
            V_HR v = new V_HR();
            v.Show();
            Visible = false;
        }

        private void Proj_Click(object sender, EventArgs e)
        {
            project p = new project();
            p.Show();
            this.Close();
        }

        private void interv_Click(object sender, EventArgs e)
        {
            Interveiw I = new Interveiw();
            I.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            feed f = new feed(0,0);
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Time T = new Time();
            T.Show();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            S.Show();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check c = new check();
            c.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete D = new Delete(0,0);
            D.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            newDep n = new newDep();
            n.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delD a = new delD();
            a.Show();
            this.Close();
        }
    }
}
