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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label7.Text = count.counter.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FootWear= new Form4();
            this.Hide();
            FootWear.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 Order_confirmation = new Form5();
            Order_confirmation.DisplayCart(SharedCart.Items);
            this.Hide();
            Order_confirmation.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Watch", Price = 1950 };
            SharedCart.Items.Add(newItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Pandet", Price = 1870 };
            SharedCart.Items.Add(newItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Golden Jewellery", Price = 1500 };
            SharedCart.Items.Add(newItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Silver Jewellery", Price = 1750 };
            SharedCart.Items.Add(newItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Name Ring", Price = 1090 };
            SharedCart.Items.Add(newItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Earing", Price = 1600 };
            SharedCart.Items.Add(newItem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
