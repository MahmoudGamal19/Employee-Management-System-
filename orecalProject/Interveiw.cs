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
    public partial class Interveiw : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
      
        public Interveiw()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Close();

        }

        private void Interveiw_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "ID_INTER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id",OracleDbType.RefCursor,ParameterDirection.Output);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Dep.Items.Add(dr[0]);
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "PROCEDURE1";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("d", Convert.ToInt32(Dep.SelectedItem.ToString()));
                cmd.Parameters.Add("lname", OracleDbType.Char,100).Direction=ParameterDirection.Output;
                cmd.Parameters.Add("loc", OracleDbType.Char,25 ).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("da", OracleDbType.Date).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("re", OracleDbType.Char,25).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("n", OracleDbType.Varchar2,2000).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("dep", OracleDbType.Int64).Direction = ParameterDirection.Output;
              int r=  cmd.ExecuteNonQuery();
              if (r != -1)
              {
                  Ename.Text = cmd.Parameters["lname"].Value.ToString();
                  Location.Text = cmd.Parameters["loc"].Value.ToString();
                  Date.Text = cmd.Parameters["da"].Value.ToString();
                  Results.Text = cmd.Parameters["re"].Value.ToString();
                  note.Text = cmd.Parameters["n"].Value.ToString();
                  textBox1.Text = cmd.Parameters["dep"].Value.ToString();
              }
                conn.Close();
                MessageBox.Show("Done Successfully ");

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Results_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
