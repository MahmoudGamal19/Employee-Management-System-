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
    public partial class Login : Form
    {
        string ordb = "Data Source=orcl; User Id=HR; Password=hr;";
        OracleConnection conn;
        int Num;
        public Login(int num)
        {
            InitializeComponent();
            Num = num;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UN_Click(object sender, EventArgs e)
        {
            UN.Text = "";
        }

        private void UN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Pass.UseSystemPasswordChar = true;
            Pass.Text = "";
           
        }

        private void LOG_Click(object sender, EventArgs e)
        {
            
            if (Num == 1) {
                
               if (UN.Text == "ADMIN" && Pass.Text == "admin")
                {
                 MessageBox.Show("LOGIN Successfully !", "LOG IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 Admin A = new Admin();
                 A.Show();
                 this.Close();               
                }
                else

                    MessageBox.Show("The UserName And Passwoed Not Exist", "LOG IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num == 2)
            {
                HR h = new HR(0, 0);
                h.Show();
                this.Close();
            }
            else {
                String un="";
                int ID;
                try {
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select username ,ID from employes ";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        un = (String)dr[0];
                        ID =Convert.ToInt32(dr[1]);
                    }
                    dr.Close();
                    if (un == UN.Text)
                    {
                        MessageBox.Show("LOGIN Successfully !", "LOG IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                        MessageBox.Show("The UserName And Passwoed Not Exist", "LOG IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Some Erros was occured " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Visible = false;
        

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
