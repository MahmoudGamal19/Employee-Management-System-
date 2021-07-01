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
    public partial class inter : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
      
        int id = 0;
        int d = 0;
        public inter(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HR h = new HR(id,d);
            h.Show();
            this.Close();
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inter i = new inter(id,d);
            i.Show();
            this.Close();
        }

        private void Data_Click(object sender, EventArgs e)
        {
            Data.Text = DateTime.Now.ToString();
        }

        private void F_N_Click(object sender, EventArgs e)
        {
            F_N.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_N_Click(object sender, EventArgs e)
        {
            M_N.Text = "";
        }

        private void L_N_Click(object sender, EventArgs e)
        {
            L_N.Text = "";
        }

        private void inter_Load(object sender, EventArgs e)
        {

        }

        private void rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }


        private void rate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("intrer rate 1 to 10 ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                {
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "MACKINTERVEIW2";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Loc", location.Text);
                    cmd.Parameters.Add("Da", Convert.ToDateTime(Data.Text));
                    cmd.Parameters.Add("fn", F_N.Text);
                    cmd.Parameters.Add("mn", M_N.Text);
                    cmd.Parameters.Add("ln", L_N.Text);
                    cmd.Parameters.Add("RE",Results.SelectedItem.ToString());
                    cmd.Parameters.Add("N",note.Text);
                    cmd.Parameters.Add("DEP",2);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Done Successfully " );
               
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Some Erros was occured " + ex.Message);
                }
            }
            

    }
}
   