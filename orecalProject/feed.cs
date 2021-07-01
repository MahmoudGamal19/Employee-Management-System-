﻿using System;
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
    public partial class feed : Form
    {
        int id = 0;
        int d = 0;
        public feed(int ID,int D)
        {
            InitializeComponent();
            d = D;
            id = ID;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Admin A = new Admin();
                A.Show();
                this.Close();
            }
            else {
                HR h = new HR(id,d);
                h.Show();
                this.Close();
            }
        }

        private void feed_Load(object sender, EventArgs e)
        {

        }
    }
}
