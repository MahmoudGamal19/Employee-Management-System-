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
    public partial class Depee : Form
    {
        int id = 0;
        int d = 0;
        public Depee(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HR h = new HR(id,d);
            h.Show();
            this.Close();
        }

        private void Dep_Load(object sender, EventArgs e)
        {

        }
    }
}
