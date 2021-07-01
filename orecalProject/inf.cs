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
    public partial class inf : Form
    {
        int id = 0;
        int d = 0;
        public inf(int ID,int D)
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

        private void inf_Load(object sender, EventArgs e)
        {

        }
    }
}
