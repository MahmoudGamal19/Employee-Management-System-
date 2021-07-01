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
    public partial class AddHR : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
        OracleDataAdapter ada;
        OracleCommandBuilder bul;
        DataSet ds;
        String cc = "";
        public AddHR()
        {
            InitializeComponent();
        }

        private void AddHR_Load(object sender, EventArgs e)
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
                    D_ID.Items.Add(dr[0]);
                }
                dr.Close();
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            check c = new check();
            c.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
            cc = "select ID from EMPLOYES where HR_ID=:h";
            ada = new OracleDataAdapter(cc, ordb);
            ada.SelectCommand.Parameters.Add("h", 1);
            ds = new DataSet();
            ada.Fill(ds);
            DataTable ta = ds.Tables[0];
            int r = ta.Rows.Count;
            int i = 0;
            while (i < r)
            {
                E_ID.Items.Add(ta.Rows[i][0].ToString());
                i++;
            }
               
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Some Erros was occured " + ex.Message);
                }
        }
    }
}
