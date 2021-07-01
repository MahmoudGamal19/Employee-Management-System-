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
    public partial class work : Form
    {
        int id = 0;
        int d = 0;

        public work(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void work_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

            EMPLOYE E = new EMPLOYE(id,d);
            E.Show();
            this.Close();
        }
    }
}
