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
    public partial class V_HR : Form
    {
        public V_HR()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Close();
        }

        private void V_HR_Load(object sender, EventArgs e)
        {

        }

    }
}
