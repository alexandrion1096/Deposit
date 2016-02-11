using System;
using System.Drawing;
using System.Windows.Forms;

namespace majong
{
    public partial class Form1 : Form
    {
        public  int[] v = new int[8];
        public int  a=0,b=0,c=0,d=0,E=0,f=0,g=0,h=0,i=0,j=0,k=0,l=0,m=0,n=0,o=0,p=0,contor = 0,nr,scor=0;
        public int ok1=0,ok2=0,ok3=0,ok4=0,ok5=0,ok6=0,ok7=0,ok8=0,ok9=0,ok10=0,ok11=0,ok12=0,ok13=0,ok14=0,ok15=0,ok16=0;
        public int v1 = 0,v2=0,v3=0,v4=0,v5=0,v6=0,v7=0,v8=0,v9=0,v10=0,v11=0,v12=0,v13=0,v14=0,v15=0,v16=0;
        public Form1()
        {
            InitializeComponent();
        }
        void culori()
        {
            Random r = new Random();
            do
            {
                nr = r.Next(8);
            } while (v[nr] == 2);
            v[nr]++;
        }
 
        public void button1_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                a = 1;
                contor++;
                if (ok1 == 0)//daca nu avem culoare la butonul 1
                {
                    culori();//apelam functia culori
                    v1 = nr;//v1 ia  valoarea lui  nr,care este o valoare random(la intamplare) trimisa de funcie
                }
                ok1 = 1;//ok il facem 1 pentru ca acum avem culoare si nu mai e necesar sa apelam functia
                //verificam valoarea lui v1 pentru a vedea ce culoare ii dam butonului 1
                if (v1 == 0)
                {
                    button1.Text = "DarkGray";
                    button1.BackColor = Color.DarkGray;
                }
                else
                    if (v1 == 1)
                    {
                        button1.Text = "DarkBlue";
                        button1.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v1 == 2)
                        {
                            button1.BackColor = Color.Pink;
                            button1.Text = "Pink";
                        }
                        else
                            if (v1 == 3)
                            {
                                button1.Text = "Red";
                                button1.BackColor = Color.Red;
                            }
                            else
                                if (v1 == 4)
                                {
                                    button1.Text = "Yellow";
                                    button1.BackColor = Color.Yellow;
                                }
                                else
                                    if (v1 == 5)
                                    {
                                        button1.Text = "Purple";
                                        button1.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v1 == 6)
                                        {
                                            button1.Text = "Orange";
                                            button1.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v1 == 7)
                                            {
                                                button1.Text = "Lime";
                                                button1.BackColor = Color.Lime;
                                            }


                button1.Enabled = false;
                timer1.Start();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                b = 1;
                contor++;
                if (ok2 == 0)
                {
                    culori();
                    v2 = nr;
                }
                ok2 = 1;
                if (v2 == 0)
                {
                    button2.Text = "DarkGray";
                    button2.BackColor = Color.DarkGray;
                }
                else
                    if (v2 == 1)
                    {
                        button2.Text = "DarkBlue";
                        button2.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v2 == 2)
                        {
                            button2.BackColor = Color.Pink;
                            button2.Text = "Pink";
                        }
                        else
                            if (v2 == 3)
                            {
                                button2.Text = "Red";
                                button2.BackColor = Color.Red;
                            }
                            else
                                if (v2 == 4)
                                {
                                    button2.Text = "Yellow";
                                    button2.BackColor = Color.Yellow;
                                }
                                else
                                    if (v2 == 5)
                                    {
                                        button2.Text = "Purple";
                                        button2.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v2 == 6)
                                        {
                                            button2.Text = "Orange";
                                            button2.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v2 == 7)
                                            {
                                                button2.Text = "Lime";
                                                button2.BackColor = Color.Lime;
                                            }


                button2.Enabled = false;
                timer1.Start();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                c = 1;
                contor++;
                if (ok3 == 0)
                {
                    culori();
                    v3 = nr;
                }
                ok3 = 1;
                if (v3 == 0)
                {
                    button3.Text = "DarkGray";
                    button3.BackColor = Color.DarkGray;
                }
                else
                    if (v3 == 1)
                    {
                        button3.Text = "DarkBlue";
                        button3.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v3 == 2)
                        {
                            button3.BackColor = Color.Pink;
                            button3.Text = "Pink";
                        }
                        else
                            if (v3 == 3)
                            {
                                button3.Text = "Red";
                                button3.BackColor = Color.Red;
                            }
                            else
                                if (v3 == 4)
                                {
                                    button3.Text = "Yellow";
                                    button3.BackColor = Color.Yellow;
                                }
                                else
                                    if (v3 == 5)
                                    {
                                        button3.Text = "Purple";
                                        button3.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v3 == 6)
                                        {
                                            button3.Text = "Orange";
                                            button3.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v3 == 7)
                                            {
                                                button3.Text = "Lime";
                                                button3.BackColor = Color.Lime;
                                            }


                button3.Enabled = false;
                timer1.Start();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                d = 1;
                contor++;
                if (ok4 == 0)
                {
                    culori();
                    v4 = nr;
                }
                ok4 = 1;
                if (v4 == 0)
                {
                    button4.Text = "DarkGray";
                    button4.BackColor = Color.DarkGray;
                }
                else
                    if (v4 == 1)
                    {
                        button4.Text = "DarkBlue";
                        button4.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v4 == 2)
                        {
                            button4.BackColor = Color.Pink;
                            button4.Text = "Pink";
                        }
                        else
                            if (v4 == 3)
                            {
                                button4.Text = "Red";
                                button4.BackColor = Color.Red;
                            }
                            else
                                if (v4 == 4)
                                {
                                    button4.Text = "Yellow";
                                    button4.BackColor = Color.Yellow;
                                }
                                else
                                    if (v4 == 5)
                                    {
                                        button4.Text = "Purple";
                                        button4.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v4 == 6)
                                        {
                                            button4.Text = "Orange";
                                            button4.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v4 == 7)
                                            {
                                                button4.Text = "Lime";
                                                button4.BackColor = Color.Lime;
                                            }


                button4.Enabled = false;
                timer1.Start();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                E = 1;
                contor++;
                if (ok5 == 0)
                {
                    culori();
                    v5 = nr;
                }
                ok5 = 1;
                if (v5 == 0)
                {
                    button5.Text = "DarkGray";
                    button5.BackColor = Color.DarkGray;
                }
                else
                    if (v5 == 1)
                    {
                        button5.Text = "DarkBlue";
                        button5.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v5 == 2)
                        {
                            button5.BackColor = Color.Pink;
                            button5.Text = "Pink";
                        }
                        else
                            if (v5 == 3)
                            {
                                button5.Text = "Red";
                                button5.BackColor = Color.Red;
                            }
                            else
                                if (v5 == 4)
                                {
                                    button5.Text = "Yellow";
                                    button5.BackColor = Color.Yellow;
                                }
                                else
                                    if (v5 == 5)
                                    {
                                        button5.Text = "Purple";
                                        button5.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v5 == 6)
                                        {
                                            button5.Text = "Orange";
                                            button5.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v5 == 7)
                                            {
                                                button5.Text = "Lime";
                                                button5.BackColor = Color.Lime;
                                            }


                button5.Enabled = false;
                timer1.Start();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                f = 1;
                contor++;
                if (ok6 == 0)
                {
                    culori();
                    v6 = nr;
                }
                ok6 = 1;
                if (v6 == 0)
                {
                    button6.Text = "DarkGray";
                    button6.BackColor = Color.DarkGray;
                }
                else
                    if (v6 == 1)
                    {
                        button6.Text = "DarkBlue";
                        button6.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v6 == 2)
                        {
                            button6.BackColor = Color.Pink;
                            button6.Text = "Pink";
                        }
                        else
                            if (v6 == 3)
                            {
                                button6.Text = "Red";
                                button6.BackColor = Color.Red;
                            }
                            else
                                if (v6 == 4)
                                {
                                    button6.Text = "Yellow";
                                    button6.BackColor = Color.Yellow;
                                }
                                else
                                    if (v6 == 5)
                                    {
                                        button6.Text = "Purple";
                                        button6.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v6 == 6)
                                        {
                                            button6.Text = "Orange";
                                            button6.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v6 == 7)
                                            {
                                                button6.Text = "Lime";
                                                button6.BackColor = Color.Lime;
                                            }


                button6.Enabled = false;
                timer1.Start();
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                g = 1;
                contor++;
                if (ok7 == 0)
                {
                    culori();
                    v7 = nr;
                }
                ok7 = 1;
                if (v7 == 0)
                {
                    button7.Text = "DarkGray";
                    button7.BackColor = Color.DarkGray;
                }
                else
                    if (v7 == 1)
                    {
                        button7.Text = "DarkBlue";
                        button7.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v7 == 2)
                        {
                            button7.BackColor = Color.Pink;
                            button7.Text = "Pink";
                        }
                        else
                            if (v7 == 3)
                            {
                                button7.Text = "Red";
                                button7.BackColor = Color.Red;
                            }
                            else
                                if (v7 == 4)
                                {
                                    button7.Text = "Yellow";
                                    button7.BackColor = Color.Yellow;
                                }
                                else
                                    if (v7 == 5)
                                    {
                                        button7.Text = "Purple";
                                        button7.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v7 == 6)
                                        {
                                            button7.Text = "Orange";
                                            button7.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v7 == 7)
                                            {
                                                button7.Text = "Lime";
                                                button7.BackColor = Color.Lime;
                                            }


                button7.Enabled = false;
                timer1.Start();

            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {h = 1;
            contor++;
            if (ok8 == 0)
            {
                culori();
                v8 = nr;
            }
            ok8 = 1;
            if (v8 == 0)
            {
                button8.Text = "DarkGray";
                button8.BackColor = Color.DarkGray;
            }
            else
                if (v8 == 1)
                {
                    button8.Text = "DarkBlue";
                    button8.BackColor = Color.DarkBlue;
                }
                else
                    if (v8 == 2)
                    {
                        button8.BackColor = Color.Pink;
                        button8.Text = "Pink";
                    }
                    else
                        if (v8 == 3)
                        {
                            button8.Text = "Red";
                            button8.BackColor = Color.Red;
                        }
                        else
                            if (v8 == 4)
                            {
                                button8.Text = "Yellow";
                                button8.BackColor = Color.Yellow;
                            }
                            else
                                if (v8 == 5)
                                {
                                    button8.Text = "Purple";
                                    button8.BackColor = Color.Purple;
                                }
                                else
                                    if (v8 == 6)
                                    {
                                        button8.Text = "Orange";
                                        button8.BackColor = Color.Orange;
                                    }
                                    else
                                        if (v8 == 7)
                                        {
                                            button8.Text = "Lime";
                                            button8.BackColor = Color.Lime;
                                        }


            button8.Enabled = false;
            timer1.Start();
        }
        }


        private void button9_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                i = 1;
                contor++;
                if (ok9 == 0)
                {
                    culori();
                    v9 = nr;
                }
                ok9 = 1;
                if (v9 == 0)
                {
                    button9.Text = "DarkGray";
                    button9.BackColor = Color.DarkGray;
                }
                else
                    if (v9 == 1)
                    {
                        button9.Text = "DarkBlue";
                        button9.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v9 == 2)
                        {
                            button9.BackColor = Color.Pink;
                            button9.Text = "Pink";
                        }
                        else
                            if (v9 == 3)
                            {
                                button9.Text = "Red";
                                button9.BackColor = Color.Red;
                            }
                            else
                                if (v9 == 4)
                                {
                                    button9.Text = "Yellow";
                                    button9.BackColor = Color.Yellow;
                                }
                                else
                                    if (v9 == 5)
                                    {
                                        button9.Text = "Purple";
                                        button9.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v9 == 6)
                                        {
                                            button9.Text = "Orange";
                                            button9.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v9 == 7)
                                            {
                                                button9.Text = "Lime";
                                                button9.BackColor = Color.Lime;
                                            }


                button9.Enabled = false;
                timer1.Start();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                j = 1;
                contor++;
                if (ok10 == 0)
                {
                    culori();
                    v10 = nr;
                }
                ok10 = 1;
                if (v10 == 0)
                {
                    button10.Text = "DarkGray";
                    button10.BackColor = Color.DarkGray;
                }
                else
                    if (v10 == 1)
                    {
                        button10.Text = "DarkBlue";
                        button10.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v10 == 2)
                        {
                            button10.BackColor = Color.Pink;
                            button10.Text = "Pink";
                        }
                        else
                            if (v10 == 3)
                            {
                                button10.Text = "Red";
                                button10.BackColor = Color.Red;
                            }
                            else
                                if (v10 == 4)
                                {
                                    button10.Text = "Yellow";
                                    button10.BackColor = Color.Yellow;
                                }
                                else
                                    if (v10 == 5)
                                    {
                                        button10.Text = "Purple";
                                        button10.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v10 == 6)
                                        {
                                            button10.Text = "Orange";
                                            button10.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v10 == 7)
                                            {
                                                button10.Text = "Lime";
                                                button10.BackColor = Color.Lime;
                                            }


                button10.Enabled = false;
                timer1.Start();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                k = 1;
                contor++;
                if (ok11 == 0)
                {
                    culori();
                    v11 = nr;
                }
                ok11 = 1;
                if (v11 == 0)
                {
                    button11.Text = "DarkGray";
                    button11.BackColor = Color.DarkGray;
                }
                else
                    if (v11 == 1)
                    {
                        button11.Text = "DarkBlue";
                        button11.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v11 == 2)
                        {
                            button11.BackColor = Color.Pink;
                            button11.Text = "Pink";
                        }
                        else
                            if (v11 == 3)
                            {
                                button11.Text = "Red";
                                button11.BackColor = Color.Red;
                            }
                            else
                                if (v11 == 4)
                                {
                                    button11.Text = "Yellow";
                                    button11.BackColor = Color.Yellow;
                                }
                                else
                                    if (v11 == 5)
                                    {
                                        button11.Text = "Purple";
                                        button11.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v11 == 6)
                                        {
                                            button11.Text = "Orange";
                                            button11.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v11 == 7)
                                            {
                                                button11.Text = "Lime";
                                                button11.BackColor = Color.Lime;
                                            }


                button11.Enabled = false;
                timer1.Start();
            }
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                l = 1;
                contor++;
                if (ok12 == 0)
                {
                    culori();
                    v12 = nr;
                }
                ok12 = 1;
                if (v12 == 0)
                {
                    button12.Text = "DarkGray";
                    button12.BackColor = Color.DarkGray;
                }
                else
                    if (v12 == 1)
                    {
                        button12.Text = "DarkBlue";
                        button12.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v12 == 2)
                        {
                            button12.BackColor = Color.Pink;
                            button12.Text = "Pink";
                        }
                        else
                            if (v12 == 3)
                            {
                                button12.Text = "Red";
                                button12.BackColor = Color.Red;
                            }
                            else
                                if (v12 == 4)
                                {
                                    button12.Text = "Yellow";
                                    button12.BackColor = Color.Yellow;
                                }
                                else
                                    if (v12 == 5)
                                    {
                                        button12.Text = "Purple";
                                        button12.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v12 == 6)
                                        {
                                            button12.Text = "Orange";
                                            button12.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v12 == 7)
                                            {
                                                button12.Text = "Lime";
                                                button12.BackColor = Color.Lime;
                                            }


                button12.Enabled = false;
                timer1.Start();
            }

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                m = 1;
                contor++;
                if (ok13 == 0)
                {
                    culori();
                    v13 = nr;
                }
                ok13 = 1;
                if (v13 == 0)
                {
                    button13.Text = "DarkGray";
                    button13.BackColor = Color.DarkGray;
                }
                else
                    if (v13 == 1)
                    {
                        button13.Text = "DarkBlue";
                        button13.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v13 == 2)
                        {
                            button13.BackColor = Color.Pink;
                            button13.Text = "Pink";
                        }
                        else
                            if (v13 == 3)
                            {
                                button13.Text = "Red";
                                button13.BackColor = Color.Red;
                            }
                            else
                                if (v13 == 4)
                                {
                                    button13.Text = "Yellow";
                                    button13.BackColor = Color.Yellow;
                                }
                                else
                                    if (v13 == 5)
                                    {
                                        button13.Text = "Purple";
                                        button13.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v13 == 6)
                                        {
                                            button13.Text = "Orange";
                                            button13.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v13 == 7)
                                            {
                                                button13.Text = "Lime";
                                                button13.BackColor = Color.Lime;
                                            }


                button13.Enabled = false;
                timer1.Start();
            }
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                n = 1;
                contor++;
                if (ok14 == 0)
                {
                    culori();
                    v14 = nr;
                }
                ok14 = 1;
                if (v14 == 0)
                {
                    button14.Text = "DarkGray";
                    button14.BackColor = Color.DarkGray;
                }
                else
                    if (v14 == 1)
                    {
                        button14.Text = "DarkBlue";
                        button14.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v14 == 2)
                        {
                            button14.BackColor = Color.Pink;
                            button14.Text = "Pink";
                        }
                        else
                            if (v14 == 3)
                            {
                                button14.Text = "Red";
                                button14.BackColor = Color.Red;
                            }
                            else
                                if (v14 == 4)
                                {
                                    button14.Text = "Yellow";
                                    button14.BackColor = Color.Yellow;
                                }
                                else
                                    if (v14 == 5)
                                    {
                                        button14.Text = "Purple";
                                        button14.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v14 == 6)
                                        {
                                            button14.Text = "Orange";
                                            button14.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v14 == 7)
                                            {
                                                button14.Text = "Lime";
                                                button14.BackColor = Color.Lime;
                                            }


                button14.Enabled = false;
                timer1.Start();
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                o = 1;
                contor++;
                if (ok15 == 0)
                {
                    culori();
                    v15 = nr;
                }
                ok15 = 1;
                if (v15 == 0)
                {
                    button15.Text = "DarkGray";
                    button15.BackColor = Color.DarkGray;
                }
                else
                    if (v15 == 1)
                    {
                        button15.Text = "DarkBlue";
                        button15.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v15 == 2)
                        {
                            button15.BackColor = Color.Pink;
                            button15.Text = "Pink";
                        }
                        else
                            if (v15 == 3)
                            {
                                button15.Text = "Red";
                                button15.BackColor = Color.Red;
                            }
                            else
                                if (v15 == 4)
                                {
                                    button15.Text = "Yellow";
                                    button15.BackColor = Color.Yellow;
                                }
                                else
                                    if (v15 == 5)
                                    {
                                        button15.Text = "Purple";
                                        button15.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v15 == 6)
                                        {
                                            button15.Text = "Orange";
                                            button15.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v15 == 7)
                                            {
                                                button15.Text = "Lime";
                                                button15.BackColor = Color.Lime;
                                            }


                button15.Enabled = false;
                timer1.Start();
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (contor != 2)
            {
                p = 1;
                contor++;
                if (ok16 == 0)
                {
                    culori();
                    v16 = nr;
                }
                ok16 = 1;
                if (v16 == 0)
                {
                    button16.Text = "DarkGray";
                    button16.BackColor = Color.DarkGray;
                }
                else
                    if (v16 == 1)
                    {
                        button16.Text = "DarkBlue";
                        button16.BackColor = Color.DarkBlue;
                    }
                    else
                        if (v16 == 2)
                        {
                            button16.BackColor = Color.Pink;
                            button16.Text = "Pink";
                        }
                        else
                            if (v16 == 3)
                            {
                                button16.Text = "Red";
                                button16.BackColor = Color.Red;
                            }
                            else
                                if (v16 == 4)
                                {
                                    button16.Text = "Yellow";
                                    button16.BackColor = Color.Yellow;
                                }
                                else
                                    if (v16 == 5)
                                    {
                                        button16.Text = "Purple";
                                        button16.BackColor = Color.Purple;
                                    }
                                    else
                                        if (v16 == 6)
                                        {
                                            button16.Text = "Orange";
                                            button16.BackColor = Color.Orange;
                                        }
                                        else
                                            if (v16 == 7)
                                            {
                                                button16.Text = "Lime";
                                                button16.BackColor = Color.Lime;
                                            }


                button16.Enabled = false;
                timer1.Start();
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            //resetam vectorul de frecvente
            for (i = 0; i <= 7; i++)
                v[i] = 0;
            //restabilim caracteristicile initiale ale butoanelor
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button1.Text = "a";
            button2.Text = "b";
            button3.Text = "c";
            button4.Text = "d";
            button5.Text = "E";
            button6.Text = "f";
            button7.Text = "g";
            button8.Text = "h";
            button9.Text = "i";
            button10.Text = "j";
            button11.Text = "k";
            button12.Text = "l";
            button13.Text = "m";
            button14.Text = "n";
            button15.Text = "o";
            button16.Text = "p";
            button1.BackColor = Color.LightGoldenrodYellow;
            button2.BackColor = Color.LightGoldenrodYellow;
            button3.BackColor = Color.LightGoldenrodYellow;
            button4.BackColor = Color.LightGoldenrodYellow;
            button5.BackColor = Color.LightGoldenrodYellow;
            button6.BackColor = Color.LightGoldenrodYellow;
            button7.BackColor = Color.LightGoldenrodYellow;
            button8.BackColor = Color.LightGoldenrodYellow;
            button9.BackColor = Color.LightGoldenrodYellow;
            button10.BackColor = Color.LightGoldenrodYellow;
            button11.BackColor = Color.LightGoldenrodYellow;
            button12.BackColor = Color.LightGoldenrodYellow;
            button13.BackColor = Color.LightGoldenrodYellow;
            button14.BackColor = Color.LightGoldenrodYellow;
            button15.BackColor = Color.LightGoldenrodYellow;
            button16.BackColor = Color.LightGoldenrodYellow;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            //resetam valorile contoarelor
           contor = a=b=c=d=E=f=g=h=i=j=k=l=m=n=o=p=0;
          //resetam valorile ok-urilor
           ok1 = ok2 = ok3 = ok4 = ok5 = ok6 = ok7 = ok8 = ok9 = ok10 = ok11 = ok12 = ok13 = ok14 = ok15 = ok16 = 0;
            //resetam scorul
           scor = 0;
           label2.Text = scor.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {  //atunci cand programul se incarca butoanele cu culori nu se vad
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (contor == 2)
            {
                timer1.Stop();
                //Verificam butonul 1 cu toate celelalte sa vedem care are aceelasi text cu el   
                if (a == 1)
                {
                    if (button1.Text == button2.Text)
                    {
                        button1.Visible = button2.Visible = false; contor = 0; a = b = 0; button1.Text = "a"; button2.Text = "b";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button1.Text == button3.Text)
                        {
                            button1.Visible = button3.Visible = false; contor = 0; a = c = 0; button1.Text = "a"; button3.Text = "c";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button1.Text == button4.Text)
                            {
                                button1.Visible = button4.Visible = false; contor = 0; a = d = 0; button1.Text = "a"; button4.Text = "d";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button1.Text == button5.Text)
                                {
                                    button1.Visible = button5.Visible = false; contor = 0; a = E = 0; button1.Text = "a"; button5.Text = "E";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button1.Text == button6.Text)
                                    {
                                        button1.Visible = button6.Visible = false; contor = 0; a = f = 0; button1.Text = "a"; button6.Text = "f";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button1.Text == button7.Text)
                                        {
                                            button1.Visible = button7.Visible = false; contor = 0; a = g = 0; button1.Text = "a"; button7.Text = "g";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button1.Text == button8.Text)
                                            {
                                                button1.Visible = button8.Visible = false; contor = 0; a = h = 0; button1.Text = "a"; button8.Text = "h";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button1.Text == button9.Text)
                                                {
                                                    button1.Visible = button9.Visible = false; contor = 0; a = i = 0; button1.Text = "a"; button9.Text = "i";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else

                                                    if (button1.Text == button10.Text)
                                                    {
                                                        button1.Visible = button10.Visible = false; contor = 0; a = j = 0; button1.Text = "a"; button10.Text = "j";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button1.Text == button11.Text)
                                                        {
                                                            button1.Visible = button11.Visible = false; contor = 0; a = k = 0; button1.Text = "a"; button11.Text = "k";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                                                        else
                                                            if (button1.Text == button12.Text)
                                                            {
                                                                button1.Visible = button12.Visible = false; contor = 0; a = l = 0; button1.Text = "a"; button12.Text = "l";
                                                                scor++; label2.Text = scor.ToString();
                                                            }
                                                            else
                                                                if (button1.Text == button13.Text)
                                                                {
                                                                    button1.Visible = button13.Visible = false; contor = 0; a = m = 0; button1.Text = "a"; button13.Text = "m";
                                                                    scor++; label2.Text = scor.ToString();
                                                                }
                                                                else
                                                                    if (button1.Text == button14.Text)
                                                                    {
                                                                        button1.Visible = button14.Visible = false; contor = 0; a = n = 0; button1.Text = "a"; button14.Text = "n";
                                                                        scor++; label2.Text = scor.ToString();
                                                                    }
                                                                    else
                                                                        if (button1.Text == button15.Text)
                                                                        {
                                                                            button1.Visible = button15.Visible = false; contor = 0; a = o = 0; button1.Text = "a"; button15.Text = "o";
                                                                            scor++; label2.Text = scor.ToString();
                                                                        }
                                                                        else
                                                                            if (button1.Text == button16.Text)
                                                                            {
                                                                                button1.Visible = button16.Visible = false; contor = 0; a = p = 0; button1.Text = "a"; button16.Text = "p";
                                                                                scor++; label2.Text = scor.ToString();
                                                                            }
                }
                if (b == 1)
                {
                    //Verificam butonul 2 cu toate celelalte sa vedem care are aceelasi text cu el 
                    if (button2.Text == button3.Text)
                    {
                        button2.Visible = button3.Visible = false; contor = 0; b = c = 0; button2.Text = "b"; button3.Text = "c";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button2.Text == button4.Text)
                        {
                            button2.Visible = button4.Visible = false; contor = 0; b = d = 0; button2.Text = "b"; button4.Text = "d";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button2.Text == button5.Text)
                            {
                                button2.Visible = button5.Visible = false; contor = 0; b = E = 0; button2.Text = "b"; button5.Text = "E";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button2.Text == button6.Text)
                                {
                                    button2.Visible = button6.Visible = false; contor = 0; b = f = 0; button2.Text = "b"; button6.Text = "f";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button2.Text == button7.Text)
                                    {
                                        button2.Visible = button7.Visible = false; contor = 0; b = g = 0; button2.Text = "b"; button7.Text = "g";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button2.Text == button8.Text)
                                        {
                                            button2.Visible = button8.Visible = false; contor = 0; b = h = 0; button2.Text = "b"; button8.Text = "h";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button2.Text == button9.Text)
                                            {
                                                button2.Visible = button9.Visible = false; contor = 0; b = i = 0; button2.Text = "b"; button9.Text = "i";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button2.Text == button10.Text)
                                                {
                                                    button2.Visible = button10.Visible = false; contor = 0; b = j = 0; button2.Text = "b"; button10.Text = "j";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button2.Text == button11.Text)
                                                    {
                                                        button2.Visible = button11.Visible = false; contor = 0; b = k = 0; button2.Text = "b"; button11.Text = "k";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button2.Text == button12.Text)
                                                        {
                                                            button2.Visible = button12.Visible = false; contor = 0; b = l = 0; button2.Text = "b"; button12.Text = "l";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                                                        else
                                                            if (button2.Text == button13.Text)
                                                            {
                                                                button2.Visible = button13.Visible = false; contor = 0; b = m = 0; button2.Text = "b"; button13.Text = "m";
                                                                scor++; label2.Text = scor.ToString();
                                                            }
                                                            else
                                                                if (button2.Text == button14.Text)
                                                                {
                                                                    button2.Visible = button14.Visible = false; contor = 0; b = n = 0; button2.Text = "b"; button14.Text = "n";
                                                                    scor++; label2.Text = scor.ToString();
                                                                }
                                                                else
                                                                    if (button2.Text == button15.Text)
                                                                    {
                                                                        button2.Visible = button15.Visible = false; contor = 0; b = o = 0; button2.Text = "b"; button15.Text = "o";
                                                                        scor++; label2.Text = scor.ToString();
                                                                    }
                                                                    else
                                                                        if (button2.Text == button16.Text)
                                                                        {
                                                                            button2.Visible = button16.Visible = false; contor = 0; b = p = 0; button2.Text = "b"; button16.Text = "p";
                                                                            scor++; label2.Text = scor.ToString();
                                                                        }
                }
                if (c == 1)
                {
                    //Verificam butonul 3 cu toate celelalte sa vedem care are aceelasi text cu el 
                    if (button3.Text == button4.Text)
                    {
                        button3.Visible = button4.Visible = false; contor = 0; c = d = 0; button3.Text = "c"; button4.Text = "d";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button3.Text == button5.Text)
                        {
                            button3.Visible = button5.Visible = false; contor = 0; c = E = 0; button3.Text = "c"; button5.Text = "E";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button3.Text == button6.Text)
                            {
                                button3.Visible = button6.Visible = false; contor = 0; c = f = 0; button3.Text = "c"; button6.Text = "f";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button3.Text == button7.Text)
                                {
                                    button3.Visible = button7.Visible = false; contor = 0; c = g = 0; button3.Text = "c"; button7.Text = "g";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button3.Text == button8.Text)
                                    {
                                        button3.Visible = button8.Visible = false; contor = 0; c = h = 0; button3.Text = "c"; button8.Text = "h";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button3.Text == button9.Text)
                                        {
                                            button3.Visible = button9.Visible = false; contor = 0; c = i = 0; button3.Text = "c"; button9.Text = "i";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button3.Text == button10.Text)
                                            {
                                                button3.Visible = button10.Visible = false; contor = 0; c = j = 0; button3.Text = "c"; button10.Text = "j";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button3.Text == button11.Text)
                                                {
                                                    button3.Visible = button11.Visible = false; contor = 0; c = k = 0; button3.Text = "c"; button11.Text = "k";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button3.Text == button12.Text)
                                                    {
                                                        button3.Visible = button12.Visible = false; contor = 0; c = l = 0; button3.Text = "c"; button12.Text = "l";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button3.Text == button13.Text)
                                                        {
                                                            button3.Visible = button13.Visible = false; contor = 0; c = m = 0; button3.Text = "c"; button13.Text = "m";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                                                        else
                                                            if (button3.Text == button14.Text)
                                                            {
                                                                button3.Visible = button14.Visible = false; contor = 0; c = n = 0; button3.Text = "c"; button14.Text = "n";
                                                                scor++; label2.Text = scor.ToString();
                                                            }
                                                            else
                                                                if (button3.Text == button15.Text)
                                                                {
                                                                    button3.Visible = button15.Visible = false; contor = 0; c = o = 0; button3.Text = "c"; button15.Text = "o";
                                                                    scor++; label2.Text = scor.ToString();
                                                                }
                                                                else
                                                                    if (button3.Text == button16.Text)
                                                                    {
                                                                        button3.Visible = button16.Visible = false; contor = 0; c = p = 0; button3.Text = "c"; button16.Text = "p";
                                                                        scor++; label2.Text = scor.ToString();
                                                                    }
                }
                if (d == 1)
                {
                    //Verificam butonul 4 cu toate celelalte sa vedem care are aceelasi text cu el 
                    if (button4.Text == button5.Text)
                    {
                        button4.Visible = button5.Visible = false; contor = 0; d = E = 0; button4.Text = "d"; button5.Text = "E";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button4.Text == button6.Text)
                        {
                            button4.Visible = button6.Visible = false; contor = 0; d = f = 0; button4.Text = "d"; button6.Text = "f";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button4.Text == button7.Text)
                            {
                                button4.Visible = button7.Visible = false; contor = 0; d = g = 0; button4.Text = "d"; button7.Text = "g";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button4.Text == button8.Text)
                                {
                                    button4.Visible = button8.Visible = false; contor = 0; d = h = 0; button4.Text = "d"; button8.Text = "h";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button4.Text == button9.Text)
                                    {
                                        button4.Visible = button9.Visible = false; contor = 0; d = i = 0; button4.Text = "d"; button9.Text = "i";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button4.Text == button10.Text)
                                        {
                                            button4.Visible = button10.Visible = false; contor = 0; d = j = 0; button4.Text = "d"; button10.Text = "j";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button4.Text == button11.Text)
                                            {
                                                button4.Visible = button11.Visible = false; contor = 0; d = k = 0; button4.Text = "d"; button11.Text = "k";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button4.Text == button12.Text)
                                                {
                                                    button4.Visible = button12.Visible = false; contor = 0; d = l = 0; button4.Text = "d"; button12.Text = "l";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button4.Text == button13.Text)
                                                    {
                                                        button4.Visible = button13.Visible = false; contor = 0; d = m = 0; button4.Text = "d"; button13.Text = "m";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button4.Text == button14.Text)
                                                        {
                                                            button4.Visible = button14.Visible = false; contor = 0; d = n = 0; button4.Text = "d"; button14.Text = "n";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                                                        else
                                                            if (button4.Text == button15.Text)
                                                            {
                                                                button4.Visible = button15.Visible = false; contor = 0; d = o = 0; button4.Text = "d"; button15.Text = "o";
                                                                scor++; label2.Text = scor.ToString();
                                                            }
                                                            else
                                                                if (button4.Text == button16.Text)
                                                                {
                                                                    button4.Visible = button16.Visible = false; contor = 0; d = p = 0; button4.Text = "d"; button16.Text = "p";
                                                                    scor++; label2.Text = scor.ToString();
                                                                }
                }
                if (E == 1)
                {
                    //Verificam butonul 5 cu toate celelalte sa vedem care are aceelasi text cu el 
                    if (button5.Text == button6.Text)
                    {
                        button5.Visible = button6.Visible = false; contor = 0; E = f = 0; button5.Text = "E"; button6.Text = "f";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button5.Text == button7.Text)
                        {
                            button5.Visible = button7.Visible = false; contor = 0; E = g = 0; button5.Text = "E"; button7.Text = "g";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button5.Text == button8.Text)
                            {
                                button5.Visible = button8.Visible = false; contor = 0; E = h = 0; button5.Text = "E"; button8.Text = "h";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button5.Text == button9.Text)
                                {
                                    button5.Visible = button9.Visible = false; contor = 0; E = i = 0; button5.Text = "E"; button9.Text = "i";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button5.Text == button10.Text)
                                    {
                                        button5.Visible = button10.Visible = false; contor = 0; E = j = 0; button5.Text = "E"; button10.Text = "j";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button5.Text == button11.Text)
                                        {
                                            button5.Visible = button11.Visible = false; contor = 0; E = k = 0; button5.Text = "E"; button11.Text = "k";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button5.Text == button12.Text)
                                            {
                                                button5.Visible = button12.Visible = false; contor = 0; E = l = 0; button5.Text = "E"; button12.Text = "l";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button5.Text == button13.Text)
                                                {
                                                    button5.Visible = button13.Visible = false; contor = 0; E = m = 0; button5.Text = "E"; button13.Text = "m";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button5.Text == button14.Text)
                                                    {
                                                        button5.Visible = button14.Visible = false; contor = 0; E = n = 0; button5.Text = "E"; button14.Text = "n";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button5.Text == button15.Text)
                                                        {
                                                            button5.Visible = button15.Visible = false; contor = 0; E = o = 0; button5.Text = "E"; button15.Text = "o";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                                                        else
                                                            if (button5.Text == button16.Text)
                                                            {
                                                                button5.Visible = button16.Visible = false; contor = 0; E = p = 0; button5.Text = "E"; button16.Text = "p";
                                                                scor++; label2.Text = scor.ToString();
                                                            }
                }
                if (f == 1)
                {
                    //Verificam butonul 6 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button6.Text == button7.Text)
                    {
                        button6.Visible = button7.Visible = false; contor = 0; f = g = 0; button6.Text = "f"; button7.Text = "g";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button6.Text == button8.Text)
                        {
                            button6.Visible = button8.Visible = false; contor = 0; f = h = 0; button6.Text = "f"; button8.Text = "h";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button6.Text == button9.Text)
                            {
                                button6.Visible = button9.Visible = false; contor = 0; f = i = 0; button6.Text = "f"; button9.Text = "i";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button6.Text == button10.Text)
                                {
                                    button6.Visible = button10.Visible = false; contor = 0; f = j = 0; button6.Text = "f"; button10.Text = "j";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button6.Text == button11.Text)
                                    {
                                        button6.Visible = button11.Visible = false; contor = 0; f = k = 0; button6.Text = "f"; button11.Text = "k";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button6.Text == button12.Text)
                                        {
                                            button6.Visible = button12.Visible = false; contor = 0; f = l = 0; button6.Text = "f"; button12.Text = "l";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button6.Text == button13.Text)
                                            {
                                                button6.Visible = button13.Visible = false; contor = 0; f = m = 0; button6.Text = "f"; button13.Text = "m";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button6.Text == button14.Text)
                                                {
                                                    button6.Visible = button14.Visible = false; contor = 0; f = n = 0; button6.Text = "f"; button14.Text = "n";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button6.Text == button15.Text)
                                                    {
                                                        button6.Visible = button15.Visible = false; contor = 0; f = o = 0; button6.Text = "f"; button15.Text = "o";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                                                    else
                                                        if (button6.Text == button16.Text)
                                                        {
                                                            button6.Visible = button16.Visible = false; contor = 0; f = p = 0; button6.Text = "f"; button16.Text = "p";
                                                            scor++; label2.Text = scor.ToString();
                                                        }
                }
                if (g == 1)
                {
                    //Verificam butonul 7 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button7.Text == button8.Text)
                    {
                        button7.Visible = button8.Visible = false; contor = 0; g = h = 0; button7.Text = "g"; button8.Text = "h";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button7.Text == button9.Text)
                        {
                            button7.Visible = button9.Visible = false; contor = 0; g = i = 0; button7.Text = "g"; button9.Text = "i";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button7.Text == button10.Text)
                            {
                                button7.Visible = button10.Visible = false; contor = 0; g = j = 0; button7.Text = "g"; button10.Text = "j";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button7.Text == button11.Text)
                                {
                                    button7.Visible = button11.Visible = false; contor = 0; g = k = 0; button7.Text = "g"; button11.Text = "k";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button7.Text == button12.Text)
                                    {
                                        button7.Visible = button12.Visible = false; contor = 0; g = l = 0; button7.Text = "g"; button12.Text = "l";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button7.Text == button13.Text)
                                        {
                                            button7.Visible = button13.Visible = false; contor = 0; g = m = 0; button7.Text = "g"; button13.Text = "m";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button7.Text == button14.Text)
                                            {
                                                button7.Visible = button14.Visible = false; contor = 0; g = n = 0; button7.Text = "g"; button14.Text = "n";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button7.Text == button15.Text)
                                                {
                                                    button7.Visible = button15.Visible = false; contor = 0; g = o = 0; button7.Text = "g"; button15.Text = "o";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                                                else
                                                    if (button7.Text == button16.Text)
                                                    {
                                                        button7.Visible = button16.Visible = false; contor = 0; g = p = 0; button7.Text = "g"; button16.Text = "p";
                                                        scor++; label2.Text = scor.ToString();
                                                    }
                }
                if (h == 1)
                {
                    //Verificam butonul 8 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button8.Text == button9.Text)
                    {
                        button8.Visible = button9.Visible = false; contor = 0; h = i = 0; button8.Text = "h"; button9.Text = "i";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button8.Text == button10.Text)
                        {
                            button8.Visible = button10.Visible = false; contor = 0; h = j = 0; button8.Text = "h"; button10.Text = "j";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button8.Text == button11.Text)
                            {
                                button8.Visible = button11.Visible = false; contor = 0; h = k = 0; button8.Text = "h"; button11.Text = "k";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button8.Text == button12.Text)
                                {
                                    button8.Visible = button12.Visible = false; contor = 0; h = l = 0; button8.Text = "h"; button12.Text = "l";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button8.Text == button13.Text)
                                    {
                                        button8.Visible = button13.Visible = false; contor = 0; h = m = 0; button8.Text = "h"; button13.Text = "m";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button8.Text == button14.Text)
                                        {
                                            button8.Visible = button14.Visible = false; contor = 0; h = n = 0; button8.Text = "h"; button14.Text = "n";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button8.Text == button15.Text)
                                            {
                                                button8.Visible = button15.Visible = false; contor = 0; h = o = 0; button8.Text = "h"; button15.Text = "o";
                                                scor++; label2.Text = scor.ToString();
                                            }
                                            else
                                                if (button8.Text == button16.Text)
                                                {
                                                    button8.Visible = button16.Visible = false; contor = 0; h = p = 0; button8.Text = "h"; button16.Text = "p";
                                                    scor++; label2.Text = scor.ToString();
                                                }
                }
                if (i == 1)
                {
                    //Verificam butonul 9 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button9.Text == button10.Text)
                    {
                        button9.Visible = button10.Visible = false; contor = 0; i = j = 0; button9.Text = "i"; button10.Text = "j";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button9.Text == button11.Text)
                        {
                            button9.Visible = button11.Visible = false; contor = 0; i = k = 0; button9.Text = "i"; button11.Text = "k";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button9.Text == button12.Text)
                            {
                                button9.Visible = button12.Visible = false; contor = 0; i = l = 0; button9.Text = "i"; button12.Text = "l";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button9.Text == button13.Text)
                                {
                                    button9.Visible = button13.Visible = false; contor = 0; i = m = 0; button9.Text = "i"; button13.Text = "m";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button9.Text == button14.Text)
                                    {
                                        button9.Visible = button14.Visible = false; contor = 0; i = n = 0; button9.Text = "i"; button14.Text = "n";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button9.Text == button15.Text)
                                        {
                                            button9.Visible = button15.Visible = false; contor = 0; i = o = 0; button9.Text = "i"; button15.Text = "o";
                                            scor++; label2.Text = scor.ToString();
                                        }
                                        else
                                            if (button9.Text == button16.Text)
                                            {
                                                button9.Visible = button16.Visible = false; contor = 0; i = p = 0; button9.Text = "i"; button16.Text = "p";
                                                scor++; label2.Text = scor.ToString();
                                            }
                }
                if (j == 1)
                {
                    //Verificam butonul 10 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button10.Text == button11.Text)
                    {
                        button10.Visible = button11.Visible = false; contor = 0; j = k = 0; button10.Text = "j"; button11.Text = "k";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button10.Text == button12.Text)
                        {
                            button10.Visible = button12.Visible = false; contor = 0; j = l = 0; button10.Text = "j"; button12.Text = "l";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button10.Text == button13.Text)
                            {
                                button10.Visible = button13.Visible = false; contor = 0; j = m = 0; button10.Text = "j"; button13.Text = "m";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button10.Text == button14.Text)
                                {
                                    button10.Visible = button14.Visible = false; contor = 0; j = n = 0; button10.Text = "j"; button14.Text = "n";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button10.Text == button15.Text)
                                    {
                                        button10.Visible = button15.Visible = false; contor = 0; j = o = 0; button10.Text = "j"; button15.Text = "o";
                                        scor++; label2.Text = scor.ToString();
                                    }
                                    else
                                        if (button10.Text == button16.Text)
                                        {
                                            button10.Visible = button16.Visible = false; contor = 0; j = p = 0; button10.Text = "j"; button16.Text = "p";
                                            scor++; label2.Text = scor.ToString();
                                        }
                }
                if (k == 1)
                {
                    //Verificam butonul 11 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button11.Text == button12.Text)
                    {
                        button11.Visible = button12.Visible = false; contor = 0; k = l = 0; button11.Text = "k"; button12.Text = "l";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button11.Text == button13.Text)
                        {
                            button11.Visible = button13.Visible = false; contor = 0; k = m = 0; button11.Text = "k"; button13.Text = "m";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button11.Text == button14.Text)
                            {
                                button11.Visible = button14.Visible = false; contor = 0; k = n = 0; button11.Text = "k"; button14.Text = "n";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button11.Text == button15.Text)
                                {
                                    button11.Visible = button15.Visible = false; contor = 0; k = o = 0; button11.Text = "k"; button15.Text = "o";
                                    scor++; label2.Text = scor.ToString();
                                }
                                else
                                    if (button11.Text == button16.Text)
                                    {
                                        button11.Visible = button16.Visible = false; contor = 0; k = p = 0; button11.Text = "k"; button16.Text = "p";
                                        scor++; label2.Text = scor.ToString();
                                    }
                }
                if (l == 1)
                {

                    //Verificam butonul 12 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button12.Text == button13.Text)
                    {
                        button12.Visible = button13.Visible = false; contor = 0; l = m = 0; button12.Text = "l"; button13.Text = "m";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button12.Text == button14.Text)
                        {
                            button12.Visible = button14.Visible = false; contor = 0; l = n = 0; button12.Text = "l"; button14.Text = "n";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button12.Text == button15.Text)
                            {
                                button12.Visible = button15.Visible = false; contor = 0; l = o = 0; button12.Text = "l"; button15.Text = "o";
                                scor++; label2.Text = scor.ToString();
                            }
                            else
                                if (button12.Text == button16.Text)
                                {
                                    button12.Visible = button16.Visible = false; contor = 0; l = p = 0; button12.Text = "l"; button16.Text = "p";
                                    scor++; label2.Text = scor.ToString();
                                }
                }
                if (m == 1)
                {
                    //Verificam butonul 13 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button13.Text == button14.Text)
                    {
                        button13.Visible = button14.Visible = false; contor = 0; m = n = 0; button13.Text = "m"; button14.Text = "n";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button13.Text == button15.Text)
                        {
                            button13.Visible = button15.Visible = false; contor = 0; m = o = 0; button13.Text = "m"; button15.Text = "o";
                            scor++; label2.Text = scor.ToString();
                        }
                        else
                            if (button13.Text == button16.Text)
                            {
                                button13.Visible = button16.Visible = false; contor = 0; m = p = 0; button13.Text = "m"; button16.Text = "p";
                                scor++; label2.Text = scor.ToString();
                            }
                }
                if (n == 1)
                {
                    //Verificam butonul 14 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button14.Text == button15.Text)
                    {
                        button14.Visible = button15.Visible = false; contor = 0; n = o = 0; button14.Text = "n"; button15.Text = "o";
                        scor++; label2.Text = scor.ToString();
                    }
                    else
                        if (button14.Text == button16.Text)
                        {
                            button14.Visible = button16.Visible = false; contor = 0; n = p = 0; button14.Text = "n"; button16.Text = "p";
                            scor++; label2.Text = scor.ToString();
                        }
                }
                if (o == 1)
                {
                    //Verificam butonul 15 cu toate celelalte sa vedem care are aceelasi text cu el
                    if (button15.Text == button16.Text)
                    {
                        button15.Visible = button16.Visible = false; contor = 0; o = p = 0; button15.Text = "o"; button16.Text = "p";
                        scor++; label2.Text = scor.ToString();
                    }
                }

                //verificam celelalte cazuri cand textele de pe butoane nu sunt egale
            
           
            
                
                        if (a == 1)
                        {
                           
                            a = 0;
                            button1.Enabled = true;
                            button1.Text = "a";
                            button1.BackColor = Color.LightGoldenrodYellow;
                           
                        }
                        if (b == 1)
                        {
                            b = 0;
                            button2.Enabled = true;
                            button2.Text = "b";
                            button2.BackColor = Color.LightGoldenrodYellow;
                            
                        }
                        if (c == 1)
                        {
                            c = 0;
                            button3.Enabled = true;
                            button3.Text = "c";
                            button3.BackColor = Color.LightGoldenrodYellow;
                            
                        }
                        if (d == 1)
                        {
                            d = 0;
                            button4.Enabled = true;
                            button4.Text = "d";
                            button4.BackColor = Color.LightGoldenrodYellow;
                          
                        }
                        if (E == 1)
                        {
                            E = 0;
                            button5.Enabled = true;
                            button5.Text = "e";
                            button5.BackColor = Color.LightGoldenrodYellow;
                           
                        }
                        if (f == 1)
                        {
                            f = 0;
                            button6.Enabled = true;
                            button6.Text = "f";
                            button6.BackColor = Color.LightGoldenrodYellow;
                           
                        }
                        if (g == 1)
                        {
                            g = 0;
                            button7.Enabled = true;
                            button7.Text = "g";
                            button7.BackColor = Color.LightGoldenrodYellow;
                         
                        }
                        if (h == 1)
                        {
                            h = 0;
                            button8.Enabled = true;
                            button8.Text = "h";
                            button8.BackColor = Color.LightGoldenrodYellow;
                           
                        }
                        if (i == 1)
                        {
                            i = 0;
                            button9.Enabled = true;
                            button9.Text = "i";
                            button9.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (j == 1)
                        {
                            j = 0;
                            button10.Enabled = true;
                            button10.Text = "j";
                            button10.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (k == 1)
                        {
                            k = 0;
                            button11.Enabled = true;
                            button11.Text = "k";
                            button11.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (l == 1)
                        {
                            l = 0;
                            button12.Enabled = true;
                            button12.Text = "l";
                            button12.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (m == 1)
                        {
                            m = 0;
                            button13.Enabled = true;
                            button13.Text = "m";
                            button13.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (n == 1)
                        {
                            n= 0;
                            button14.Enabled = true;
                            button14.Text = "n";
                            button14.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (o == 1)
                        {
                            o = 0;
                            button15.Enabled = true;
                            button15.Text = "o";
                            button15.BackColor = Color.LightGoldenrodYellow;

                        }
                        if (p == 1)
                        {
                            p= 0;
                            button16.Enabled = true;
                            button16.Text = "p";
                            button16.BackColor = Color.LightGoldenrodYellow;

                        }
                        contor = 0;
                    }
            if (button1.Visible == false && button2.Visible == false && button3.Visible == false && button4.Visible == false && button5.Visible == false && button6.Visible == false && button7.Visible == false && button8.Visible == false && button9.Visible == false && button10.Visible == false && button11.Visible == false && button12.Visible == false && button13.Visible == false && button14.Visible == false && button15.Visible == false && button16.Visible == false)
            {
               
                MessageBox.Show("Congratulations!");
                

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= 7; i++)
                v[i] = 0;
            button17.Visible = false;
            button18.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
    }
