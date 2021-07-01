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
    public partial class V_Emp : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
       
        public V_Emp()
        {
            InitializeComponent();
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            Visible = false;
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Close();
        }
        
        private void V_Emp_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from HR_DEPARTMENT";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Dep.Items.Add(dr[0]);
                }
                dr.Close();
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            } 
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        
        


    }
}
