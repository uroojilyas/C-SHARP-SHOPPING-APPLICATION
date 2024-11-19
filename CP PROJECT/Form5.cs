using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CP_PROJECT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label5.Text = count.counter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FootWear= new Form4();
            this.Hide();
            FootWear.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 Home= new Form1();
            this.Hide();
            Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Outfits = new Form2();
            this.Hide();
            Outfits.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Accessories = new Form3();
            this.Hide();
            Accessories.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void DisplayCart(List<CartItem> cart)
        {
            dataGridView1.DataSource = null; // Clear previous data binding
            dataGridView1.DataSource = cart; // Rebind to the shared cart

            // Calculate total amount
            decimal totalAmount = cart.Sum(item => item.Price);

            // Display total amount in the label
            totalAmountlbl.Text = $"Rs.{totalAmount}";
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void SaveToTextFile(string name, string address, string phoneNumber)
        {
            // Specify the file path where you want to save the data
            string filePath = "C:\\Users\\AST\\Desktop\\AUSA.TXT";

            // Open the file in append mode and write the customer information
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Format the data as needed (e.g., tab-separated values)
                string dataLine = $"{name}\t{address}\t{phoneNumber}";

                // Write the data to the file
                writer.WriteLine(dataLine);
                Form2 Outfits= new Form2();
                this.Close();
                Outfits.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get user input from TextBoxes
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhone.Text;
            // Save the information to a text file
            SaveToTextFile(name, address, phoneNumber);
            // Clear the underlying data source
            
           // count.counter = 0;
            SharedCart.Items.Clear();
            // Refresh the DataGridView to reflect the changes
            DisplayCart(SharedCart.Items);
            // Reset the counter to zero
            count.counter= 0;
            label5.Text = count.counter.ToString();
            // Save the cart data to a text file
            MessageBox.Show("your order is placed");
         
        }
       
            private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
