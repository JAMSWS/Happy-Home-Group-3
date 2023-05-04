using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Appliances_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            

            }

            else
            {
                txtPassword.PasswordChar = '•';
              
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {

                MessageBox.Show("Login Success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard().Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUsername.Text = "";
                txtPassword.Focus();

            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtPassword.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Registrationfrm().Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
