using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CP_PROJECT
{
    public partial class login : Form
    {
        private string credentialsFile = "C:\\Users\\AST\\OneDrive\\Desktop\\urooj.TXT";
       /* static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }*/
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (CheckCredentials(username, password))
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password or User Name");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
        private bool CheckCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines(credentialsFile);

            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }

            return false;
        }
    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
