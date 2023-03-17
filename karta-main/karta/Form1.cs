using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "финиш";
            panel1.Visible = true;
            label1.Visible = true;
            label3.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            label1.Text = "Метро Киевская";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Visible = false;
            label6.Visible = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "МЦК Лужники";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "Новодевичей монастырь";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label6.Text = "Стойка информации";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "МИД";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "Парк Горького";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label6.Text = "Стойка информации";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "Здания РАН";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "Метро Воробевы горы";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label6.Text = "Стойка информации";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true
            label1.Text = "Стадион Лужники";
            label2.Text = "Стенд питья";
            label3.Text = "Энергетические батончики";
            label4.Text = "Тулет";
            label5.Text = "Мед пункт";
            label6.Text = "Стойка информации";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
        }
    }
    }

