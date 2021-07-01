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
    public partial class project : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn; 
        public project()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            Admin A = new Admin();
            A.Show();
            this.Close();
        }

        private void project_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select NAME from PROJECTS";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   proj.Items.Add(dr[0]);
                }
                dr.Close();
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            } 
        }

        private void proj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ID,DISCRIPTION,HR_ID from PROJECTS where NAME=:N";
                cmd.Parameters.Add("NAME", proj.Text);
                OracleDataReader dr = cmd.ExecuteReader();
               while  (dr.Read())
                {
                   
                    pro_id.Text = Convert.ToString(dr[0]);
                    richTextBox1.Text =Convert.ToString(dr[1]);
                    IDD.Text = Convert.ToString(dr[2]);
                }
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select EMPLOYEE_ID from WORKES_ON where PRO_NAME=:N";
                cmd.Parameters.Add("NAME", proj.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EWI.Items.Add(dr[0]);
                }
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
        }
    }
}
