using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label10.Text=count.counter.ToString();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 Home= new Form1();
            this.Hide();
            Home.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form3 Accessories= new Form3();
            this.Hide();
            Accessories.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 FootWear = new Form4();
            this.Hide();
            FootWear.Show();
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            Form5 Order_confirmation = new Form5();
            Order_confirmation.DisplayCart(SharedCart.Items);
            this.Hide();
            Order_confirmation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Printed Dress", Price = 1320};
            SharedCart.Items.Add(newItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Stylish Kurti", Price = 1500};
            SharedCart.Items.Add(newItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Mustard Kurti", Price = 1800 };
            SharedCart.Items.Add(newItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Printed Frock", Price = 1950 };
            SharedCart.Items.Add(newItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Frock", Price = 1900 };
            SharedCart.Items.Add(newItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Plain Dress", Price = 1870 };
            SharedCart.Items.Add(newItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "White Plain", Price = 2000 };
            SharedCart.Items.Add(newItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Jeans and shirt", Price = 1950 };
            SharedCart.Items.Add(newItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count.counter++;
            label10.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Jeans&Fancy shirt", Price = 2300 };
            SharedCart.Items.Add(newItem);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
