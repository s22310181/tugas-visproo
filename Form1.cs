using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "12345")
            {
               
                Form2 dashboard = new Form2();
                this.Hide(); 
                dashboard.ShowDialog(); 
                this.Show();
            }
            else
            {
                MessageBox.Show(
                    "Username atau Password salah!",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
