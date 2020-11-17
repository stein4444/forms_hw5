using System;
using System.Drawing;
using System.Windows.Forms;

namespace forms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ClearLines()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text) &&
                !String.IsNullOrEmpty(this.textBox2.Text) &&
               !String.IsNullOrEmpty(this.textBox3.Text))
            {
                this.label5.Text = this.textBox1.Text;
                this.label6.Text = this.textBox2.Text;
                this.label7.Text = this.textBox3.Text;
                ClearLines();
            }
            else
            {
                MessageBox.Show("Error fill all lines\n" + MessageBoxButtons.OK);
                ClearLines();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string picture = "Rusik.jpg";
            Image image = Image.FromFile(picture);
            this.pictureBox1.Image = image;
            this.pictureBox2.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))
            {
                this.label16.Text = textBox4.Text;
                this.label17.Text = textBox5.Text;
                ClearLines();
            }
            else
            {
                MessageBox.Show("Error fill all lines\n" + MessageBoxButtons.OK);
                ClearLines();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Про мене";
            this.label2.Text = "Ім'я";
            this.label3.Text = "Статус";
            this.label8.Text = "Про мене";
            this.label9.Text = "Хоббі";
            this.label10.Text = "Робота";
            this.label14.Text = "Номер телефону";
            this.label15.Text = "Мейл";
            this.label18.Text = "Змінити контакти";
            this.tabPage1.Text = "Домашня сторінка";
            this.tabPage2.Text = "Про мене";
            this.tabPage3.Text = "Контакти";
            this.tabPage4.Text = "Налаштування";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "About Me";
            this.label2.Text = "Name";
            this.label3.Text = "Status";
            this.label8.Text = "About me";
            this.label9.Text = "Hobby";
            this.label10.Text = "Job";
            this.label14.Text = "Phone number";
            this.label15.Text = "Email";
            this.label18.Text = "Change contacts";
            this.tabPage1.Text = "Home";
            this.tabPage2.Text = "About me";
            this.tabPage3.Text = "Contact";
            this.tabPage4.Text = "Settings";
        }
    }
}
