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
    public partial class EMPLOYE : Form
    {
        int id = 0;
        int d = 0;
        public EMPLOYE(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void EMPLOYE_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_feed c = new C_feed(id,d);
            c.Show();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Y_inf_Click(object sender, EventArgs e)
        {
            inf i = new inf(id,d);
            i.Show();
            this.Close();
        }

        private void Edite_Click(object sender, EventArgs e)
        {
            edet es = new edet(id,d);
            es.Show();
            this.Close();
        }

        private void TS_Click(object sender, EventArgs e)
        {
            Time1 T = new Time1(id,d);
            T.Show();
            this.Close();
        }

        private void W_Click(object sender, EventArgs e)
        {
            work w = new work(id,d);
            w.Show();
            this.Close();
        }
    }
}
