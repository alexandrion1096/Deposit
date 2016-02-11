using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a,nivel,c=0;
        int verifica_easy_valoare()
        {if(button1.Text == "1" && button2.Text == "2" && button5.Text == "3" && button6.Text == "")
            return 1;
            else
            return 0;
        }
        void verifica_easy()
        {
            if (button1.Text == "1" && button2.Text == "2" && button5.Text == "3" && button6.Text == "")
            {
                MessageBox.Show("Well done, " + " you rezolved it in " + c + " clicks!");
                //vom bloca butoanele urmatoare pentru a nu putea juca
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                //vor aparea butoanele "again" si "exit"
                button21.Visible = true;
                button22.Visible = true;
            
            }
        }
        void veririca_medium()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button5.Text == "4" && button6.Text == "5" && button7.Text == "6" && button9.Text == "7" && button10.Text == "8" && button11.Text == "")
            {
                MessageBox.Show("Well done, " + " you rezolved it in " + c + " clicks!");
                button21.Visible = true;
                button22.Visible = true;
                //vom bloca butoanele urmatoare pentru a nu putea juca
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                //vor aparea butoanele "again" si "exit"
                button21.Visible = true;
                button22.Visible = true;
            }
        }
        void veririfica_hard()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("Well done, " + " you rezolved it in " + c + " clicks!");
                //vom bloca butoanele urmatoare pentru a nu putea juca
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                //vor aparea butoanele "again" si "exit"
                button21.Visible = true;
                button22.Visible = true;
            }
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            c++;
            if (button15.Text == "")
            {
                button15.Text = button16.Text;
                button16.Text = "";
                veririfica_hard();
            }
            else
                if (button12.Text == "")
                {
                    button12.Text = button16.Text;
                    button16.Text = "";
                    veririfica_hard();
                }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c++;
            if (button16.Text == "")
            {button16.Text = button15.Text;
                button15.Text="";
                if (nivel == 3)
                    veririfica_hard();
                
            }
            else
                if (button11.Text == "")
                {
                    button11.Text = button15.Text;
                    button15.Text = "";
                    veririfica_hard();
                }
                else
                    if (button14.Text == "")
                    {
                        button14.Text = button15.Text;
                        button15.Text = "";
                        veririfica_hard();
                       
                    }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            c++;
            if (button15.Text == "")
            {
                button15.Text = button14.Text;
                button14.Text = "";
                if (nivel == 3)
                    veririfica_hard();
                
            }
            else
                if (button10.Text == "")
                {
                    button10.Text = button14.Text;
                    button14.Text = "";
                    if (nivel == 3)
                        veririfica_hard();
                    
                }
                else
                    if (button13.Text == "")
                    {
                        button13.Text = button14.Text;
                        button14.Text = "";
                        if (nivel == 3)
                            veririfica_hard();                        
                    }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c++;
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
                veririfica_hard();
               
            }
            else
                if (button14.Text == "")
                {
                    button14.Text = button13.Text;
                    button13.Text = "";
                    veririfica_hard();
                   
                }
               
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c++;
            if (button16.Text == "")
            {
                button16.Text = button12.Text;
                button12.Text = "";
                veririfica_hard();
                
            }
            else
                if (button11.Text == "")
                {
                    button11.Text = button12.Text;
                    button12.Text = "";
                    veririfica_hard();
                   
                }
                else
                    if (button8.Text == "")
                    {
                        button8.Text = button12.Text;
                        button12.Text = "";
                        veririfica_hard();
                    }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c++;
            if (button15.Text == "")
            {
                button15.Text = button11.Text;
                button11.Text = "";
                veririfica_hard();
                
            }
            else
                if (button10.Text == "")
                {
                    button10.Text = button11.Text;
                    button11.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
                    
                }
                else
                    if (button7.Text == "")
                    {
                        button7.Text = button11.Text;
                        button11.Text = "";
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if(nivel==3)
                        veririfica_hard();
                      
                    }
                    else
                        if (button12.Text == "")
                        {
                            button12.Text = button11.Text;
                            button11.Text = "";
                            veririfica_hard();
                            
                        }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            c++;
            if (button14.Text == "")
            {
                button14.Text = button10.Text;
                button10.Text = "";
                veririfica_hard();
            }
            else
                if (button9.Text == "")
                {
                    button9.Text = button10.Text;
                    button10.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
                }
                else
                    if (button6.Text == "")
                    {
                        button6.Text = button10.Text;
                        button10.Text = "";
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if (nivel == 3)
                                veririfica_hard();
                    }
                    else
                        if (button11.Text == "")
                        {
                            button11.Text = button10.Text;
                            button10.Text = "";
                            if (nivel == 2)
                                veririca_medium();
                            else
                                if (nivel == 3)
                                    veririfica_hard();
                        }
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            c++;
            if (button13.Text == "")
            {
                button13.Text = button9.Text;
                button9.Text = "";
                veririfica_hard();
            }
            else
                if (button5.Text == "")
                {
                    button5.Text = button9.Text;
                    button9.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
                }
                else
                    if (button10.Text == "")
                    {
                        button10.Text = button9.Text;
                        button9.Text = "";
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if (nivel == 3)
                                veririfica_hard();
                    }

          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c++;
            if (button12.Text == "")
            {
                button12.Text = button8.Text;
                button8.Text = "";
                veririfica_hard();
            }
            else
                if (button7.Text == "")
                {
                    button7.Text = button8.Text;
                    button8.Text = "";
                    veririfica_hard();
                }
                else
                    if (button4.Text == "")
                    {
                        button4.Text = button8.Text;
                        button8.Text = "";
                        veririfica_hard();
                    }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c++;
            if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
                if (nivel == 2)
                    veririca_medium();
                else
                    if (nivel == 3)
                        veririfica_hard();
            }
            else
                if (button11.Text == "")
                {
                    button11.Text = button7.Text;
                    button7.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
                }
                else
                    if (button8.Text == "")
                    {
                        button8.Text = button7.Text;
                        button7.Text = "";
                        veririfica_hard();
                    }
                    else
                        if (button3.Text == "")
                        {
                            button3.Text = button7.Text;
                            button7.Text = "";
                            if (nivel == 2)
                                veririca_medium();
                            else
                                if (nivel == 3)
                                    veririfica_hard();
                        }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c++;
            if (button7.Text == "")
            {
                button7.Text = button6.Text;
                button6.Text = "";
                if (nivel == 2)
                    veririca_medium();
                else
                    if (nivel == 3)
                        veririfica_hard();
            }
            else
                if (button10.Text == "")
                {
                    button10.Text = button6.Text;
                    button6.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
                }
                else
                    if (button5.Text == "")
                    {
                        button5.Text = button6.Text;
                        button6.Text = "";
                        if (nivel == 1)
                        verifica_easy();
                        else
                            if (nivel == 2)
                                veririca_medium();
                            else
                                if (nivel == 3)
                                    veririfica_hard();
                    }
                    else
                        if (button2.Text == "")
                        {
                            button2.Text = button6.Text;
                            button6.Text = "";
                            if (nivel == 1) 
                                verifica_easy();
                            else
                                if (nivel == 2)
                                    veririca_medium();
                                else
                                    if (nivel == 3)
                                        veririfica_hard();
                        }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c++;
            if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
                if (nivel == 2)
                    veririca_medium();
                else
                    if (nivel == 3)
                        veririfica_hard();
            }
            else
                if (button6.Text == "")
                {
                    button6.Text = button5.Text;
                    button5.Text = "";
                    if (nivel == 1)
                    verifica_easy();
                    else
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if (nivel == 3)
                                veririfica_hard();
                }
                else
                    if (button1.Text == "")
                    {
                        button1.Text = button5.Text;
                        button5.Text = "";
                        if (nivel == 1)
                            verifica_easy();
                        else
                            if (nivel == 2)
                                veririca_medium();
                            else
                                if (nivel == 3)
                                    veririfica_hard();
                    }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c++;
            if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
                veririfica_hard();
            }
            else
                if (button3.Text == "")
                {
                    button3.Text = button4.Text;
                    button4.Text = "";
                    veririfica_hard();
                }
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c++;
            if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
                if (nivel == 2)
                    veririca_medium();
                else
                    if (nivel == 3)
                        veririfica_hard();
            }
            else
                if (button2.Text == "")
                {
                    button2.Text = button3.Text;
                    button3.Text = "";
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();

                }
                else
                    if (button4.Text == "")
                    {
                        button4.Text = button3.Text;
                        button3.Text = "";
                        veririfica_hard();
                    }
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c++;
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
                if (nivel == 2)
                    veririca_medium();
                else
                    if (nivel == 3)
                        veririfica_hard();
            }
            else
                if (button6.Text == "")
                {
                    button6.Text = button2.Text;
                    button2.Text = "";
                    if (nivel == 1) 
                        verifica_easy();
                    else
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if (nivel == 3)
                                veririfica_hard();
                }
                else
                    if (button1.Text == "")
                    {
                        button1.Text = button2.Text;
                        button2.Text = "";
                        if (nivel == 1) 
                            verifica_easy();
                        else
                            if (nivel == 2)
                                veririca_medium();
                            else
                                if (nivel == 3)
                                    veririfica_hard();
                    }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            if (button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
                if (nivel == 1) 
                    verifica_easy();
                else
                    if (nivel == 2)
                        veririca_medium();
                    else
                        if (nivel == 3)
                            veririfica_hard();
            }
            else
                if (button2.Text == "")
                {
                    button2.Text = button1.Text;
                    button1.Text = "";
                    if (nivel == 1)
                        verifica_easy();
                    else
                        if (nivel == 2)
                            veririca_medium();
                        else
                            if (nivel == 3)
                                veririfica_hard();
                }
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        void amesteca_hard()
        {
            int i = 0, j = 0, n = 0, m = 0, nr = 0, inversiuni = 0, pozitie = 0, ok = 0;
            int[] x = new int[17];
            int[] a = new int[16];
            int[,] v = new int[5, 5];
           
            Random r = new Random();
            while (ok == 0)
            {
                for (i = 0; i <= 15; i++)
                    a[i] = 0;
                for (i = 1; i <= 16; i++)
                    x[i] = 0;
                n = m =inversiuni=pozitie=0;
                while (n < 16)
                {
                    nr = r.Next(16);
                    if (a[nr] == 0)
                    {
                        x[++n] = nr;
                        a[nr] = 1;
                    }

                }
                for (i = 1; i <= 4; i++)
                    for (j = 1; j <= 4; j++)
                    {
                        v[i, j] = x[++m];
                        if (v[i, j] == 0)
                            pozitie = i;
                    }
                for (i = 1; i < n; i++)
                    for (j = i + 1; j <= n; j++)
                        if (x[i] > x[j] && x[j]!=0)
                            inversiuni++;
                if ((inversiuni % 2 == 0 && pozitie % 2 == 0) || (inversiuni % 2 == 1 && pozitie % 2 == 1))
                { ok = 1;
                if (v[1, 1] == 0)
                    button1.Text = "";
                else
                    button1.Text = v[1, 1].ToString();
                if (v[1, 2] == 0)
                    button2.Text = "";
                else
                    button2.Text = v[1, 2].ToString();
                if (v[1, 3] == 0)
                    button3.Text = "";
                else
                    button3.Text = v[1, 3].ToString();
                if (v[1, 4] == 0)
                    button4.Text = "";
                else
                    button4.Text = v[1, 4].ToString();
                if (v[2, 1] == 0)
                    button5.Text = "";
                else
                    button5.Text = v[2, 1].ToString();
                if (v[2, 2] == 0)
                    button6.Text = "";
                else
                    button6.Text = v[2, 2].ToString();
                if (v[2, 3] == 0)
                    button7.Text = "";
                else
                    button7.Text = v[2, 3].ToString();
                if (v[2, 4] == 0)
                    button8.Text = "";
                else
                    button8.Text = v[2, 4].ToString();
                if (v[3, 1] == 0)
                    button9.Text = "";
                else
                    button9.Text = v[3, 1].ToString();
                if (v[3, 2] == 0)
                    button10.Text = "";
                else
                    button10.Text = v[3, 2].ToString();
                if (v[3, 3] == 0)
                    button11.Text = "";
                else
                    button11.Text = v[3, 3].ToString();
                if (v[3, 4] == 0)
                    button12.Text = "";
                else
                    button12.Text = v[3, 4].ToString();
                if (v[4, 1] == 0)
                    button13.Text = "";
                else
                    button13.Text = v[4, 1].ToString();
                if (v[4, 2] == 0)
                    button14.Text = "";
                else
                    button14.Text = v[4, 2].ToString();
                if (v[4, 3] == 0)
                    button15.Text = "";
                else
                   button15.Text=v[4,3].ToString();
                    
                if (v[4, 4] == 0)
                    button16.Text = "";
                else
                    button16.Text = v[4, 4].ToString();
                  
                    
                }
            }
        }
        void amesteca_medium()
        {
            int i = 0, j = 0, n = 0, m = 0, nr = 0, inversiuni = 0, ok = 0;
            int[] x = new int[10];
            int[] a = new int[9];
            int[,] v = new int[4, 4];
            
            Random r = new Random();
            while (ok == 0 )
            {
                for (i = 0; i <= 8; i++)
                    a[i] = 0;
                for (i = 1; i <= 9; i++)
                    x[i] = 0;
                n = m = inversiuni = 0;
                while (n < 9)
                {
                    nr = r.Next(9);
                    if (a[nr] == 0)
                    {
                        x[++n] = nr;
                        a[nr] = 1;
                    }
                }
               
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                        v[i, j] = x[++m];

                for (i = 1; i < n; i++)
                    for (j = i + 1; j <= n; j++)
                        if (x[i] > x[j] && x[j]!=0)
                            inversiuni++;
                if (inversiuni % 2 == 0)
                { ok = 1;
                if (v[1, 1] == 0)
                    button1.Text = "";
                else
                    button1.Text = v[1, 1].ToString();
                if (v[1, 2] == 0)
                    button2.Text = "";
                else
                    button2.Text = v[1, 2].ToString();
                if (v[1, 3] == 0)
                    button3.Text = "";
                else
                    button3.Text = v[1, 3].ToString();
                if (v[2, 1] == 0)
                    button5.Text = "";
                else
                    button5.Text = v[2, 1].ToString();
                if (v[2, 2] == 0)
                    button6.Text = "";
                else
                    button6.Text = v[2, 2].ToString();
                if (v[2, 3] == 0)
                    button7.Text = "";
                else
                    button7.Text = v[2, 3].ToString();
                if (v[3, 1] == 0)
                    button9.Text = "";
                else
                    button9.Text = v[3, 1].ToString();
                if (v[3, 2] == 0)
                    button10.Text = "";
                else
                    button10.Text = v[3, 2].ToString();
                if (v[3, 3] == 0)
                    button11.Text = "";
                else
                    button11.Text = v[3, 3].ToString();
                
                }
            }
        }
        void amesteca_easy()
        {
            int i = 0, j = 0, n = 0, m = 0, nr = 0, inversiuni = 0, pozitie = 0, ok = 0;
            int[] x = new int[5];
            int[] a = new int[4];
            int[,] v = new int[3, 3];
            Random r = new Random();
            while (ok == 0)
            {
                for (i = 0; i <= 3; i++)
                    a[i] = 0;
                for (i = 1; i <= 4; i++)
                    x[i] = 0;
                n = m = inversiuni = pozitie = 0;
                while (n < 4)
                {
                    nr = r.Next(4);
                    if (a[nr] == 0)
                    {
                        x[++n] = nr;
                        a[nr] = 1;
                    }

                }
                for (i = 1; i <= 2; i++)
                    for (j = 1; j <= 2; j++)
                    {
                        v[i, j] = x[++m];
                        if (v[i, j] == 0)
                            pozitie = i;
                    }
                for (i = 1; i < n; i++)
                    for (j = i + 1; j <= n; j++)
                        if (x[i] > x[j] && x[j]!=0)
                            inversiuni++;
                if (((inversiuni % 2 == 0 && pozitie % 2 == 0) || (inversiuni % 2 == 1 && pozitie % 2 == 1)))
                { ok = 1;

                if ((button1.Text == "" && button2.Text == v[1, 2].ToString() && button5.Text == v[2, 1].ToString() && button6.Text == v[2, 2].ToString()) || (button1.Text == v[1, 1].ToString() && button2.Text =="" && button5.Text == v[2,1].ToString() && button6.Text == v[2, 2].ToString()) || (button1.Text == v[1, 1].ToString() && button2.Text == v[1,2].ToString() && button5.Text == "".ToString() && button6.Text == v[2, 2].ToString()) || (button1.Text == v[1, 1].ToString() && button2.Text == v[1,2].ToString() && button5.Text == v[2, 1].ToString() && button6.Text ==""))
                    ok = 0;
                else
                {
                    if (v[1, 1] == 0)
                        button1.Text = "";
                    else
                        button1.Text = v[1, 1].ToString();
                    if (v[1, 2] == 0)
                        button2.Text = "";
                    else
                        button2.Text = v[1, 2].ToString();
                    if (v[2, 1] == 0)
                        button5.Text = "";
                    else
                        button5.Text = v[2, 1].ToString();
                    if (v[2, 2] == 0)
                        button6.Text = "";
                    else
                        button6.Text = v[2, 2].ToString();
                }
                if (verifica_easy_valoare() == 1)
                    ok = 0;
                }
            }
                
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button17.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            nivel = 1;
            a = 1;//stim ca a fost selectat easy
            //nivelul selectat este easy
            //vor aparea urmatoarele butoane
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            //vor disparea urmatoarele butoane
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            //vom amesteca
            amesteca_easy();

           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nivel = 2;
            //nivelul selectat este medium
            //vor aparea urmatoarele butoane
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            //vor disparea urmatoarele butoane
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            //vom amesteca
            amesteca_medium();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
                nivel = 3;
                //nivelul selectat este hard
                //vor aparea urmatoarele butoane
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
                //vor disparea urmatoarele butoane
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                //vom amesteca butoanele
                amesteca_hard();
            

        }

       private void easyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            c = 0;//resetam contorul pentru click-uri
            if (button1.Enabled == true && button2.Enabled == true && button3.Enabled == true && button4.Enabled == true && button5.Enabled == true && button6.Enabled == true && button7.Enabled == true && button8.Enabled == true && button9.Enabled == true && button10.Enabled == true && button11.Enabled == true && button12.Enabled == true && button13.Enabled == true && button14.Enabled == true && button15.Enabled == true && button16.Enabled == true)
            {
                nivel = 1;
                a = 1;//stim ca fost selectat easy
                //vor disparea butoanele
                button3.Visible = false;
                button4.Visible = false;
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
                //vom "borda" matricea pentru a nu disparea butonane
                button3.Text = "1";
                button7.Text = "1";
                button10.Text = "1";
                button9.Text = "1";
                //vom amesteca
                amesteca_easy();
            }
        }

        private void mediumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            c = 0;//resetam contorul pentru click-uri
            if (button1.Enabled == true && button2.Enabled == true && button3.Enabled == true && button4.Enabled == true && button5.Enabled == true && button6.Enabled == true && button7.Enabled == true && button8.Enabled == true && button9.Enabled == true && button10.Enabled == true && button11.Enabled == true && button12.Enabled == true && button13.Enabled == true && button14.Enabled == true && button15.Enabled == true && button16.Enabled == true)
            {
                nivel = 2;
                if (a == 1)//daca modul selectat a fost easy atunci trebuie sa apara butoane
                {
                    button3.Visible = true;
                    button7.Visible = true;
                    button11.Visible = true;
                    button10.Visible = true;
                    button9.Visible = true;
                    //vom amesteca
                    amesteca_medium();
                    a = 0;
                }
                else
                {//vor disparea butoanele pentru ca nivelul selectat a fost hard
                    button4.Visible = false;
                    button8.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    button15.Visible = false;
                    button16.Visible = false;
                    //vom amesteca
                    amesteca_medium();
                }
                //vom borda matricea pentru a nu disparea butoane
                button4.Text = "1";
                button8.Text = "1";
                button12.Text = "1";
                button16.Text = "1";
                button15.Text = "1";
                button14.Text = "1";
                button13.Text = "1";

            }
        }
       private void hardToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
            c = 0;//resetam contorul pentru click-uri
            if (button1.Enabled == true && button2.Enabled == true && button3.Enabled == true && button4.Enabled == true && button5.Enabled == true && button6.Enabled == true && button7.Enabled == true && button8.Enabled == true && button9.Enabled == true && button10.Enabled == true && button11.Enabled == true && button12.Enabled == true && button13.Enabled == true && button14.Enabled == true && button15.Enabled == true && button16.Enabled == true)
            {
                nivel = 3;
                //vor aparea urmatoarele butoane
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
                //vom amesteca
                amesteca_hard();
                a = 0;
            }
        }
       

        private void shffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true && button2.Enabled == true && button3.Enabled == true && button4.Enabled == true && button5.Enabled == true && button6.Enabled == true && button7.Enabled == true && button8.Enabled == true && button9.Enabled == true && button10.Enabled == true && button11.Enabled == true && button12.Enabled == true && button13.Enabled == true && button14.Enabled == true && button15.Enabled == true && button16.Enabled == true)
               if(nivel==1)
                amesteca_easy();
            else
                if (nivel == 2)
                    amesteca_medium();
                else
                    if (nivel == 3)
                        amesteca_hard();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
         
        }

        private void button21_Click(object sender, EventArgs e)
        {
            c = 0;//resetam contorul pentru click-uri
            if (nivel == 1)
            {
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
                amesteca_easy();
            }
            else
                if (nivel == 2)
                {
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
                    amesteca_medium(); }
                else
                    if (nivel == 3)
                    {
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
                        amesteca_hard(); }
            button21.Visible = false;
            button22.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puzzle Game (Gem Puzzle, Boss Puzzle, Game of Fifteen, Mystic Square) este un puzzle format din 16, 9, sau 4 piese (în funcție de dificultatea aleasă) numerotate aleator, una dintre aceste piese fiind goală. Obiectivul acestui puzzle este de a plasa fiecare piesă în ordine prin mișcări de glisare folosind piesa goală. ");
        }
 

    
    }

       
    }