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
    public partial class addpro : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn; 
        int id = 0;
        int d = 0;
        public addpro(int ID,int D)
        {
            InitializeComponent();
            id = ID;
            d = D;
        }

        private void addpro_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ID from HR_DEPARTMENT";
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

        private void button1_Click(object sender, EventArgs e)
        {
        
            HR h = new HR(id,d);
            h.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into PROJECTS (ID,NAME,DISCRIPTION,HR_ID)values (proj_S.nextval,:N,:D,:H)";
                cmd.Parameters.Add("N",pn.Text);
                cmd.Parameters.Add("D",richTextBox1.Text);
                cmd.Parameters.Add("H", Dep.SelectedText);
                int r = cmd.ExecuteNonQuery();
                if(r!=-1)
                    MessageBox.Show("Date Inserted !", "Insert ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Some Erros was occured " + ex.Message);
            } 
        }
        }

    }


            