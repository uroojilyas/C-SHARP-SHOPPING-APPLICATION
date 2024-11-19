using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CP_PROJECT
{
    public partial class signup : Form
    {
        private string credentialsFile = "C:\\Users\\AST\\OneDrive\\Desktop\\urooj.TXT";
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new signup());
        }
        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Append the new user to the credentials file
            File.AppendAllText(credentialsFile, $"{username},{password}{Environment.NewLine}");
            login login= new login();   
            this.Hide();
            login.Show();
            MessageBox.Show("Signup successful! You can now login with your credentials.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            
            login.Show();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
