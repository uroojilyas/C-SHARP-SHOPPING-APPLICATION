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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           label7.Text = count.counter.ToString();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 OUtfits = new Form2();
            this.Hide();
            OUtfits.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Accessories = new Form3();
            this.Hide();
            Accessories.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Order_confirmation = new Form5();
            Order_confirmation.DisplayCart(SharedCart.Items);
            this.Hide();
            Order_confirmation.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Shoes", Price = 1950};
            SharedCart.Items.Add(newItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Sandels", Price = 1900 };
            SharedCart.Items.Add(newItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Block heel", Price = 1850 };
            SharedCart.Items.Add(newItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Fancy heel", Price = 2000 };
            SharedCart.Items.Add(newItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "khusa", Price = 1850 };
            SharedCart.Items.Add(newItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count.counter++;
            label7.Text = count.counter.ToString();
            CartItem newItem = new CartItem { ItemName = "Shoes", Price = 1750 };
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

