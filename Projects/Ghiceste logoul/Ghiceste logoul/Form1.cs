using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ghiceste_logoul
{
    public partial class Form1 : Form
    {
         public int a=-1;
         public long  b = 1;
        public int r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (b == 1)
            {
                if (textBox1.Text == "McDonald's" || textBox1.Text == "McDonalds")
                {
                    button4.Enabled = false;
                    r1 = 1;
                    textBox1.Enabled = false;
                    MessageBox.Show("Corect!");
                }
                else
                    MessageBox.Show("Mai incearca!");
            }
            else
                if (b == 2)
                {

                    if (textBox1.Text == "KFC" || textBox1.Text == "kfc")
                    {
                        button4.Enabled = false;
                        r2 = 1;
                        textBox1.Enabled = false;
                        MessageBox.Show("Corect!");
                    }
                    else
                        MessageBox.Show("Mai incearca!");

                }
                else
                    if (b == 3)
                    {

                        if (textBox1.Text == "Mercedes" || textBox1.Text == "Mercedes Benz" || textBox1.Text == "Mercedes-Benz")
                        {
                            button4.Enabled = false;
                            r3 = 1;
                            textBox1.Enabled = false;
                            MessageBox.Show("Corect!");
                        }
                        else
                            MessageBox.Show("Mai incearca!");

                    }
                    else
                        if (b == 4)
                        {

                            if (textBox1.Text == "Cplusplus" || textBox1.Text == "C++" || textBox1.Text == "c++")
                            {
                                button4.Enabled = false;
                                r4 = 1;
                                textBox1.Enabled = false;
                                MessageBox.Show("Corect!");
                            }
                            else
                                MessageBox.Show("Mai incearca!");
                        }
                        else
                            if (b == 5)
                            {

                                if (textBox1.Text == "Linux")
                                {
                                    button4.Enabled = false;
                                    r5 = 1;
                                    textBox1.Enabled = false;
                                    MessageBox.Show("Corect!");
                                }
                                else
                                    MessageBox.Show("Mai incearca!");

                            }
                            else
                                if (b == 6)
                                {

                                    if (textBox1.Text == "Mozilla Firefox" || textBox1.Text == "Mozilla" || textBox1.Text == "Firefox")
                                    {
                                        button4.Enabled = false;
                                        r6 = 1;
                                        MessageBox.Show("Corect!");
                                        textBox1.Enabled = false;
                                    }
                                    else
                                        MessageBox.Show("Mai incearca!");

                                }
                                else
                                    if (b == 7)
                                    {

                                        if (textBox1.Text == "Monster Energy" || textBox1.Text == "Monster")
                                        {
                                            button4.Enabled = false;
                                            r7 = 1;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Corect!");
                                        }
                                        else
                                            MessageBox.Show("Mai incearca!");

                                    }
                                    else
                                        if (b == 8)
                                        {

                                            if (textBox1.Text == "The Rolling Stones" || textBox1.Text == "Rolling Stones")
                                            {
                                                button4.Enabled = false;
                                                r8 = 1;
                                                textBox1.Enabled = false;
                                                MessageBox.Show("Corect!");
                                            }
                                            else
                                                MessageBox.Show("Mai incearca!");

                                        }
                                        else
                                            if (b == 9)
                                            {

                                                if (textBox1.Text == "Scania")
                                                {
                                                    button4.Enabled = false;
                                                    r9 = 1;
                                                    textBox1.Enabled = false;
                                                    MessageBox.Show("Corect!");
                                                }
                                                else
                                                    MessageBox.Show("Mai incearca!");

                                            }
                                            else
                                                if (b == 10)
                                                {

                                                    if (textBox1.Text == "Apple")
                                                    {
                                                        button4.Enabled = false;
                                                        r10 = 1;
                                                        textBox1.Enabled = false;
                                                        MessageBox.Show("Corect!");
                                                    }
                                                    else
                                                        MessageBox.Show("Mai incearca!");

                                                }
                                                else
                                                    if (b == 11)
                                                    {

                                                        if (textBox1.Text == "Windows")
                                                        {
                                                            button4.Enabled = false;
                                                            r11 = 1;
                                                            textBox1.Enabled = false;
                                                            MessageBox.Show("Corect!");
                                                        }
                                                        else
                                                            MessageBox.Show("Mai incearca!");

                                                    }
                                                    else
                                                        if (b == 12)
                                                        {

                                                            if (textBox1.Text == "Lotto")
                                                            {
                                                                button4.Enabled = false;
                                                                r12 = 1;
                                                                textBox1.Enabled = false;
                                                                MessageBox.Show("Corect!");
                                                            }
                                                            else
                                                                MessageBox.Show("Mai incearca!");

                                                        }
                                                        else
                                                            if (b == 13)
                                                            {

                                                                if (textBox1.Text == "Chevrolet")
                                                                {
                                                                    button4.Enabled = false;
                                                                    r13 = 1;
                                                                    textBox1.Enabled = false;
                                                                    MessageBox.Show("Corect!");
                                                                }
                                                                else
                                                                    MessageBox.Show("Mai incearca!");

                                                            }
                                                            else
                                                                if (b == 14)
                                                                {

                                                                    if (textBox1.Text == "Bosch")
                                                                    {
                                                                        button4.Enabled = false;
                                                                        r14 = 1;
                                                                        textBox1.Enabled = false;
                                                                        MessageBox.Show("Corect!");
                                                                    }
                                                                    else
                                                                        MessageBox.Show("Mai incearca!");

                                                                }
                                                                else
                                                                    if (b == 15)
                                                                    {

                                                                        if (textBox1.Text == "Yamaha")
                                                                        {
                                                                            button4.Enabled = false;
                                                                            r15 = 1;
                                                                            textBox1.Enabled = false;
                                                                            MessageBox.Show("Corect!");
                                                                        }
                                                                        else
                                                                            MessageBox.Show("Mai incearca!");

                                                                    }
                                                                    else
                                                                        if (b == 16)
                                                                        {

                                                                            if (textBox1.Text == "Lays")
                                                                            {
                                                                                button4.Enabled = false;
                                                                                r16 = 1;
                                                                                textBox1.Enabled = false;
                                                                                MessageBox.Show("Corect!");
                                                                            }
                                                                            else
                                                                                MessageBox.Show("Mai incearca!");

                                                                        }
                                                                        else
                                                                            if (b == 17)
                                                                            {

                                                                                if (textBox1.Text == "Pepsi")
                                                                                {
                                                                                    button4.Enabled = false;
                                                                                    r17 = 1;
                                                                                    textBox1.Enabled = false;
                                                                                    MessageBox.Show("Corect!");
                                                                                }
                                                                                else
                                                                                    MessageBox.Show("Mai incearca!");

                                                                            }
                                                                            else
                                                                                if (b == 18)
                                                                                {

                                                                                    if (textBox1.Text == "IBM")
                                                                                    {
                                                                                        button4.Enabled = false;
                                                                                        r18 = 1;
                                                                                        textBox1.Enabled = false;
                                                                                        MessageBox.Show("Corect!");
                                                                                    }
                                                                                    else
                                                                                        MessageBox.Show("Mai incearca!");

                                                                                }
                                                                                else
                                                                                    if (b == 19)
                                                                                    {

                                                                                        if (textBox1.Text == "Jagermeister")
                                                                                        {
                                                                                            button4.Enabled = false;
                                                                                            r19 = 1;
                                                                                            textBox1.Enabled = false;
                                                                                            MessageBox.Show("Corect!");
                                                                                        }
                                                                                        else
                                                                                            MessageBox.Show("Mai incearca!");

                                                                                    }
                                                                                    else

                                                                                        if (b == 20)
                                                                                        {

                                                                                            if (textBox1.Text == "Wrestling")
                                                                                            {
                                                                                                button4.Enabled = false;
                                                                                                r20 = 1;
                                                                                                textBox1.Enabled = false;
                                                                                                MessageBox.Show("Corect!");
                                                                                            }
                                                                                            else
                                                                                                MessageBox.Show("Mai incearca!");

                                                                                        }

            if (r1 == 1 && r2 == 1 && r3 == 1 && r4 == 1 && r5 == 1 && r6 == 1 && r7 == 1 && r8 == 1 && r9 == 1 && r10 == 1 && r11 == 1 && r12 == 1 && r13 == 1 && r14 == 1 && r15 == 1 && r16 == 1 && r17 == 1 && r18 == 1 && r19 == 1 && r20 == 1)
            {
                MessageBox.Show("Jocul s-a terminat,toate logo-urile sunt completate corect!");
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled =true;
            textBox1.Enabled = true;
            button2.Enabled = true;
            textBox1.Text = "";
            pictureBox1.Image = imageList1.Images[++a];
            b++;
            if (a == 19)
            {
                button1.Enabled = false;
                
            }
         
            if (r1 == 1 && b == 1)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r2 == 1 && b == 2)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r3 == 1 && b == 3)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r4 == 1 && b == 4)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r5 == 1 && b == 5)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r6 == 1 && b == 6)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r7 == 1 && b == 7)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r8 == 1 && b == 8)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r9 == 1 && b == 9)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r10 == 1 && b == 10)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r11 == 1 && b == 11)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r12 == 1 && b == 12)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r13 == 1 && b == 13)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r14 == 1 && b == 14)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r15 == 1 && b == 15)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            } if (r16 == 1 && b == 16)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r17 == 1 && b == 17)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r18 == 1 && b == 18)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r19 == 1 && b == 19)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r20 == 1 && b == 20)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            textBox1.Enabled = true;
            button1.Enabled = true;
            textBox1.Text = "";
            pictureBox1.Image = imageList1.Images[--a];
            b--;
            if (a == 0)
            {    
                button2.Enabled = false;
               
                
            }

            if (r1 == 1 && b == 1)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r2 == 1 && b == 2)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r3 == 1 && b == 3)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r4 == 1 && b == 4)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r5 == 1 && b == 5)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r6 == 1 && b == 6)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r7 == 1 && b == 7)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r8 == 1 && b == 8)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r9 == 1 && b == 9)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r10 == 1 && b == 10)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r11 == 1 && b == 11)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r12 == 1 && b == 12)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r13 == 1 && b == 13)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r14 == 1 && b == 14)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r15 == 1 && b == 15)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            } if (r16 == 1 && b == 16)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r17 == 1 && b == 17)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r18 == 1 && b == 18)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r19 == 1 && b == 19)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
            if (r20 == 1 && b == 20)
            {
                textBox1.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {  
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Visible = true;
            button5.Visible = false;
            pictureBox1.Image = imageList1.Images[0];
            a++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            pictureBox1.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
            button4.Enabled = true;

            a = -1;
            b = 1;
            r1 = r2 = r3 = r4 = r5 = r6 = r7 = r8 = r9 = r10 = r11 = r12 = r13 = r14 = r15 = r16 = r17 = r18 = r19 = r20 = 0;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        
       
    }
}
