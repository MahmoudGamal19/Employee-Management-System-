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
    public partial class AddHR2 : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
        OracleDataAdapter ada;
        OracleCommandBuilder bul;
        DataSet ds;
        String cc = "";
        public AddHR2()
        {
            InitializeComponent();
        }

        private void F_N_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_N_Click(object sender, EventArgs e)
        {
            L_N.Text = "";
        }

        private void M_N_Click(object sender, EventArgs e)
        {
            M_N.Text = "";
        }

        private void F_N_Click(object sender, EventArgs e)
        {
            F_N.Text = "";
        }

        private void SSN_Click(object sender, EventArgs e)
        {
            SSN.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            check c = new check();
            c.Show();
            this.Close();
        }

        private void AddHR2_Load(object sender, EventArgs e)
        {
           try
            {
                cc = @"select ID from HR_DEPARTMENT";
                ada = new OracleDataAdapter(cc, ordb);
                ds = new DataSet();
                ada.Fill(ds);
                DataTable ta = ds.Tables[0];
                int r = ta.Rows.Count;
                int i = 0;
                while (i < r)
                {
                    Dep.Items.Add(ta.Rows[i][0].ToString());
                    i++;
                }
                
           }
                

            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into HR_OFFICIERS (ID,FNAME,MNAME,LNAME,ADRESS,PHONE,USERNAME,PASS,SSN,DATE_OF_EMPLOYMENT,HR_ID,SALARY)values ( S_IDH.nextval,:fn,:mn,:ln,:a,:p,:u,:pa,:ss,:D,:H,:s)";
            cmd.Parameters.Add("fn", F_N.Text);
            cmd.Parameters.Add("mn",M_N.Text);
            cmd.Parameters.Add("ln",L_N.Text);
            cmd.Parameters.Add("a",ad.Text);
            cmd.Parameters.Add("p",Int32.Parse(PH.Text));
            cmd.Parameters.Add("u",UN.Text);
            cmd.Parameters.Add("pa",Pass.Text);
            cmd.Parameters.Add("ss",Int64.Parse(SSN.Text));
            cmd.Parameters.Add("D",Convert.ToDateTime(DateTime.Now.ToString()));
            cmd.Parameters.Add("H",Int32.Parse(Dep.SelectedItem.ToString()));
            cmd.Parameters.Add("s", Int64.Parse(Sal.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("Date Inserted !", "Insert ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }
    }
}
