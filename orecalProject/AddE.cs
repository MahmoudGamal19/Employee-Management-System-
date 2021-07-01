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
    public partial class AddE : Form
    {
        int id = 0;
        int d = 0;

        public AddE(int ID ,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void AddE_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            HR h = new HR(id,d);
            h.Show();
            this.Close();
        }
    }
}
