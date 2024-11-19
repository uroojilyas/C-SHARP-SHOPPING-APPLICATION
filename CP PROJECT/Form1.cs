using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text=count.counter.ToString();
        }
            private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 3)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Image\{0}.png", imageNumber);
            imageNumber++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 Outfits = new Form2();
            Outfits.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Accessories= new Form3();
            this.Hide();
            Accessories.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FootWear= new Form4();
            this.Hide();
            FootWear.Show();         
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 My_Cart= new Form5();
            this.Hide();
            My_Cart.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 Order_confirmation = new Form5();
            Order_confirmation.DisplayCart(SharedCart.Items);
            this.Hide();
            Order_confirmation.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            this.Close();
            signup.Show();
        }
    }
}
