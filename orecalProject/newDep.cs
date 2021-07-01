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
    public partial class newDep : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn; 
        public newDep()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
        }

        private void newDep_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into HR_DEPARTMENT (ID,LOCATIONS) values (HR_D.nextval,:L) ";
            cmd.Parameters.Add("L", textBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) {
                MessageBox.Show("Data iserted ", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("rong !", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Some Erros was occured :" + ex.Message);
                }
             conn.Close();

             textBox1.Text = "";
        }
    }
}
