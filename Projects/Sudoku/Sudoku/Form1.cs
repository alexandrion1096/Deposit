using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public int [,]a=new int [10,10];
        public int level;
         int verifica(int[,] a, int l, int c, int stg, int dr, int sus, int jos, int x)
        {
            int i, j;
            for (i = 1; i <= 9; i++)
                if (a[i, c] == x)
                    return 0;
            for (j = 1; j <= 9; j++)
                if (a[l, j] == x)
                    return 0;
            for (i = sus; i <= jos; i++)
                for (j = stg; j <= dr; j++)
                    if (a[i, j] == x)
                        return 0;
            return 1;
        }
        void genereaza(int[,] a)
        {
            int x, i, j, c, sus, jos, stg, dr;
            Random r;
            r = new Random();
            for (i = 1; i <= 9; i++)
                for (j = 1; j <= 9; j++)
                    a[i, j] = 0;
            for (i = 1; i <= 9; i++)
                for (j = 1; j <= 9; j++)
                {
                    c = 0;
                    do
                    {
                        c++;
                        x = r.Next(1, 10);
                        if (j <= 3)
                        { stg = 1; dr = 3; }
                        else
                            if (j <= 6)
                            { stg = 4; dr = 6; }
                            else
                            { stg = 7; dr = 9; }
                        if (i <= 3)
                        { sus = 1; jos = 3; }
                        else
                            if (i <= 6)
                            { sus = 4; jos = 6; }
                            else
                            { sus = 7; jos = 9; }
                        if (c > 5)
                        {
                            c = 0;
                            if (j > 1)
                            {
                                j--;
                                a[i, j] = 0;
                            }
                            else
                            {
                                if (i > 1)
                                {
                                    j = 9;
                                    i--;
                                    a[i, j] = 0;
                                }
                                else
                                    if (i == 1 && j == 1)
                                        a[i, j] = 0;
                            }
                        }
                    } while (verifica(a, i, j, stg, dr, sus, jos, x) == 0);
                    a[i, j] = x;
                }
        }

         void completeaza(int level)
       {
           int i, j, c = 0;
           int[,] b = new int[10, 10];
            genereaza(a);

            for (i = 1; i <= 9; i++)
               for (j = 1; j <= 9; j++)
                   b[i, j] = a[i, j];
           Random x;
           x = new Random();
             if(level==1)
           while (c != 21)
           {
               i = x.Next(1,10);
               j = x.Next(1, 10);
               if (b[i, j] != 0)
               {
                   c++;
                   b[i, j] = 0;
               }
           }
             else
                 if(level==2)
                     while (c != 41)
                     {
                         i = x.Next(1, 10);
                         j = x.Next(1, 10);
                         if (b[i, j] != 0)
                         {
                             c++;
                             b[i, j] = 0;
                         }
                     }
             else
                     while (c != 61)
                     {
                         i = x.Next(1, 10);
                         j = x.Next(1, 10);
                         if (b[i, j] != 0)
                         {
                             c++;
                             b[i, j] = 0;
                         }
                     }

           textBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
           textBox4.Text = "";
           textBox5.Text = "";
           textBox6.Text = "";
           textBox7.Text = "";
           textBox8.Text = "";
           textBox9.Text = "";
           textBox10.Text = "";
           textBox11.Text = "";
           textBox12.Text = "";
           textBox13.Text = "";
           textBox14.Text = "";
           textBox15.Text = "";
           textBox16.Text = "";
           textBox17.Text = "";
           textBox18.Text = "";
           textBox19.Text = "";
           textBox20.Text = "";
           textBox21.Text = "";
           textBox22.Text = "";
           textBox23.Text = "";
           textBox24.Text = "";
           textBox25.Text = "";
           textBox26.Text = "";
           textBox27.Text = "";
           textBox28.Text = "";
           textBox29.Text = "";
           textBox30.Text = "";
           textBox31.Text = "";
           textBox32.Text = "";
           textBox33.Text = "";
           textBox34.Text = "";
           textBox35.Text = "";
           textBox36.Text = "";
           textBox37.Text = "";
           textBox38.Text = "";
           textBox39.Text = "";
           textBox40.Text = "";
           textBox41.Text = "";
           textBox42.Text = "";
           textBox43.Text = "";
           textBox44.Text = "";
           textBox45.Text = "";
           textBox46.Text = "";
           textBox47.Text = "";
           textBox48.Text = "";
           textBox49.Text = "";
           textBox50.Text = "";
           textBox51.Text = "";
           textBox52.Text = "";
           textBox53.Text = "";
           textBox54.Text = "";
           textBox55.Text = "";
           textBox56.Text = "";
           textBox57.Text = "";
           textBox58.Text = "";
           textBox59.Text = "";
           textBox60.Text = "";
           textBox61.Text = "";
           textBox62.Text = "";
           textBox63.Text = "";
           textBox64.Text = "";
           textBox65.Text = "";
           textBox66.Text = "";
           textBox67.Text = "";
           textBox68.Text = "";
           textBox69.Text = "";
           textBox70.Text = "";
           textBox71.Text = "";
           textBox72.Text = "";
           textBox73.Text = "";
           textBox74.Text = "";
           textBox75.Text = "";
           textBox76.Text = "";
           textBox77.Text = "";
           textBox78.Text = "";
           textBox79.Text = "";
           textBox80.Text = "";
           textBox81.Text = "";

            if (b[1, 1] != 0)
               textBox1.Text = b[1, 1].ToString();
           if (b[1, 2] != 0)
               textBox2.Text = b[1, 2].ToString();
            if(b[1, 3]!=0)
                textBox3.Text = b[1, 3].ToString();         
            if (b[1, 4] != 0)
                textBox4.Text = b[1, 4].ToString();
            if (b[1, 5] != 0)
                textBox5.Text = b[1, 5].ToString();
            if (b[1, 6] != 0)
                textBox6.Text = b[1, 6].ToString();
            if(b[1, 7]!=0)
           textBox7.Text = b[1, 7].ToString();
            if(b[1,8]!=0)
           textBox8.Text = b[1, 8].ToString();
            if (b[1, 9] != 0)
           textBox9.Text = b[1, 9].ToString();
            if (b[2, 1] != 0)
           textBox10.Text = b[2, 1].ToString();
            if (b[2, 2] != 0)
           textBox11.Text = b[2, 2].ToString();
           if (b[2, 3] != 0)
            textBox12.Text = b[2, 3].ToString();
           if ( b[2, 4]!= 0)
            textBox13.Text = b[2, 4].ToString();
           if (b[2, 5] != 0)
            textBox14.Text = b[2, 5].ToString();
           if (b[2, 6] != 0)
            textBox15.Text = b[2, 6].ToString();
          if ( b[2, 7]!= 0)
            textBox16.Text = b[2, 7].ToString();
          if ( b[2, 8]!= 0)
            textBox17.Text = b[2, 8].ToString();
           if (b[2, 9] != 0)
            textBox18.Text = b[2, 9].ToString();
          if (b[3, 1] != 0)
            textBox19.Text = b[3, 1].ToString();
           if (b[3, 2] != 0)
            textBox20.Text = b[3, 2].ToString();
           if (b[3, 3] != 0)
            textBox21.Text = b[3, 3].ToString();
           if (b[3, 4] != 0)
            textBox22.Text = b[3, 4].ToString();
           if ( b[3, 5]!= 0)
            textBox23.Text = b[3, 5].ToString();
           if (b[3, 6] != 0)
            textBox24.Text = b[3, 6].ToString();
           if (b[3, 7] != 0)
            textBox25.Text = b[3, 7].ToString();
           if (b[3, 8] != 0)
            textBox26.Text = b[3, 8].ToString();
          if ( b[3, 9]!= 0)
            textBox27.Text = b[3, 9].ToString();
           if (b[4, 1] != 0)
            textBox28.Text = b[4, 1].ToString();
          if ( b[4, 2]!= 0)
            textBox29.Text = b[4, 2].ToString();
           if (b[4, 3] != 0)
            textBox30.Text = b[4, 3].ToString();
           if (b[4, 4] != 0)
            textBox31.Text = b[4, 4].ToString();
           if ( b[4, 5]!= 0)
            textBox32.Text = b[4, 5].ToString();
           if ( b[4, 6]!= 0)
            textBox33.Text = b[4, 6].ToString();
           if (b[4, 7] != 0)
            textBox34.Text = b[4, 7].ToString();
           if (b[4, 8] != 0)
            textBox35.Text = b[4, 8].ToString();
           if ( b[4, 9]!= 0)
            textBox36.Text = b[4, 9].ToString();
           if (b[5, 1] != 0)
            textBox37.Text = b[5, 1].ToString();
           if (b[5, 2] != 0)
            textBox38.Text = b[5, 2].ToString();
           if (b[5, 3] != 0)
            textBox39.Text = b[5, 3].ToString();
           if ( b[5, 4]!= 0)
            textBox40.Text = b[5, 4].ToString();
           if ( b[5, 5]!= 0)
            textBox41.Text = b[5, 5].ToString();
          if ( b[5, 6]!= 0)
            textBox42.Text = b[5, 6].ToString();
           if (b[5, 7] != 0)
            textBox43.Text = b[5, 7].ToString();
           if ( b[5, 8]!= 0)
            textBox44.Text = b[5, 8].ToString();
           if ( b[5, 9]!= 0)
            textBox45.Text = b[5, 9].ToString();
           if (b[6, 1] != 0)
            textBox46.Text = b[6, 1].ToString();
           if (b[6, 2] != 0)
            textBox47.Text = b[6, 2].ToString();
           if (b[6, 3] != 0)
            textBox48.Text = b[6, 3].ToString();
           if (b[6, 4] != 0)
            textBox49.Text = b[6, 4].ToString();
           if (b[6, 5] != 0)
            textBox50.Text = b[6, 5].ToString();
           if ( b[6, 6]!= 0)
            textBox51.Text = b[6, 6].ToString();
          if (b[6, 7] != 0)
            textBox52.Text = b[6, 7].ToString();
           if (b[6, 8] != 0)
            textBox53.Text = b[6, 8].ToString();
           if (b[6, 9] != 0)
            textBox54.Text = b[6, 9].ToString();
           if (b[7, 1] != 0)
            textBox55.Text = b[7, 1].ToString();
           if (b[7, 2] != 0)
            textBox56.Text = b[7, 2].ToString();
           if (b[7, 3] != 0)
            textBox57.Text = b[7, 3].ToString();
           if ( b[7, 4]!= 0)
            textBox58.Text = b[7, 4].ToString();
           if (b[7, 5] != 0)
            textBox59.Text = b[7, 5].ToString();
           if (b[7, 6] != 0)
            textBox60.Text = b[7, 6].ToString();
           if (b[7, 7] != 0)
            textBox61.Text = b[7, 7].ToString();
           if (b[7, 8] != 0)
            textBox62.Text = b[7, 8].ToString();
           if ( b[7, 9]!= 0)
            textBox63.Text = b[7, 9].ToString();
           if (b[8, 1] != 0)
            textBox64.Text = b[8, 1].ToString();
          if ( b[8, 2]!= 0)
            textBox65.Text = b[8, 2].ToString();
          if (b[8, 3] != 0)
            textBox66.Text = b[8, 3].ToString();
          if (b[8, 4] != 0)
            textBox67.Text = b[8, 4].ToString();
          if (b[8, 5] != 0)
            textBox68.Text = b[8, 5].ToString();
           if (b[8, 6] != 0)
            textBox69.Text = b[8, 6].ToString();
           if (b[8, 7] != 0)
            textBox70.Text = b[8, 7].ToString();
          if (b[8, 8] != 0)
            textBox71.Text = b[8, 8].ToString();
          if ( b[8, 9]!= 0)
            textBox72.Text = b[8, 9].ToString();
           if ( b[9, 1]!= 0)
            textBox73.Text = b[9, 1].ToString();
           if (b[9, 2] != 0)
            textBox74.Text = b[9, 2].ToString();
           if ( b[9, 3]!= 0)
            textBox75.Text = b[9, 3].ToString();
           if ( b[9, 4]!= 0)
            textBox76.Text = b[9, 4].ToString();
           if (  b[9, 5]!= 0)
            textBox77.Text = b[9, 5].ToString();
           if (b[9, 6] != 0)
            textBox78.Text = b[9, 6].ToString();
          if ( b[9, 7]!= 0)
            textBox79.Text = b[9, 7].ToString();
           if (b[9, 8] != 0)
            textBox80.Text = b[9, 8].ToString();
           if (b[9, 9] != 0)
            textBox81.Text = b[9, 9].ToString();

    }
         void verifica_numere()
         {
             if (textBox1.Text == a[1, 1].ToString())
                 textBox1.BackColor = Color.LightGray;
             else
                 textBox1.BackColor = Color.RoyalBlue;

             if (textBox2.Text == a[1, 2].ToString())
                 textBox2.BackColor = Color.LightGray;
             else
                 textBox2.BackColor = Color.RoyalBlue;

             if (textBox3.Text == a[1, 3].ToString())
                 textBox3.BackColor = Color.LightGray;
             else
                 textBox3.BackColor = Color.RoyalBlue;

             if (textBox4.Text == a[1, 4].ToString())
                 textBox4.BackColor = Color.LightGray;
             else
                 textBox4.BackColor = Color.RoyalBlue;

             if (textBox5.Text == a[1, 5].ToString())
                 textBox5.BackColor = Color.LightGray;
             else
                 textBox5.BackColor = Color.RoyalBlue;

             if (textBox6.Text == a[1, 6].ToString())
                 textBox6.BackColor = Color.LightGray;
             else
                 textBox6.BackColor = Color.RoyalBlue;

             if (textBox7.Text == a[1, 7].ToString())
                 textBox7.BackColor = Color.LightGray;
             else
                 textBox7.BackColor = Color.RoyalBlue;

             if (textBox8.Text == a[1, 8].ToString())
                 textBox8.BackColor = Color.LightGray;
             else
                 textBox8.BackColor = Color.RoyalBlue;

             if (textBox9.Text == a[1, 9].ToString())
                 textBox9.BackColor = Color.LightGray;
             else
                 textBox9.BackColor = Color.RoyalBlue;

             if (textBox10.Text == a[2, 1].ToString())
                 textBox10.BackColor = Color.LightGray;
             else
                 textBox10.BackColor = Color.RoyalBlue;

             if (textBox11.Text == a[2, 2].ToString())
                 textBox11.BackColor = Color.LightGray;
             else
                 textBox11.BackColor = Color.RoyalBlue;

             if (textBox12.Text == a[2, 3].ToString())
                 textBox12.BackColor = Color.LightGray;
             else
                 textBox12.BackColor = Color.RoyalBlue;

             if (textBox13.Text == a[2, 4].ToString())
                 textBox13.BackColor = Color.LightGray;
             else
                 textBox13.BackColor = Color.RoyalBlue;

             if (textBox14.Text == a[2, 5].ToString())
                 textBox14.BackColor = Color.LightGray;
             else
                 textBox14.BackColor = Color.RoyalBlue;

             if (textBox15.Text == a[2, 6].ToString())
                 textBox15.BackColor = Color.LightGray;
             else
                 textBox15.BackColor = Color.RoyalBlue;

             if (textBox16.Text == a[2, 7].ToString())
                 textBox16.BackColor = Color.LightGray;
             else
                 textBox16.BackColor = Color.RoyalBlue;

             if (textBox17.Text == a[2, 8].ToString())
                 textBox17.BackColor = Color.LightGray;
             else
                 textBox17.BackColor = Color.RoyalBlue;

             if (textBox18.Text == a[2, 9].ToString())
                 textBox18.BackColor = Color.LightGray;
             else
                 textBox18.BackColor = Color.RoyalBlue;

             if (textBox19.Text == a[3, 1].ToString())
                 textBox19.BackColor = Color.LightGray;
             else
                 textBox19.BackColor = Color.RoyalBlue;

             if (textBox20.Text == a[3, 2].ToString())
                 textBox20.BackColor = Color.LightGray;
             else
                 textBox20.BackColor = Color.RoyalBlue;

             if (textBox21.Text == a[3, 3].ToString())
                 textBox21.BackColor = Color.LightGray;
             else
                 textBox21.BackColor = Color.RoyalBlue;

             if (textBox22.Text == a[3, 4].ToString())
                  textBox22.BackColor = Color.LightGray;
             else
                 textBox22.BackColor = Color.RoyalBlue;

             if (textBox23.Text == a[3, 5].ToString())
                 textBox23.BackColor = Color.LightGray;
             else
                 textBox23.BackColor = Color.RoyalBlue;

             if (textBox24.Text == a[3, 6].ToString())
                 textBox24.BackColor = Color.LightGray;
             else
                 textBox24.BackColor = Color.RoyalBlue;

             if (textBox25.Text == a[3, 7].ToString())
                 textBox25.BackColor = Color.LightGray;
             else
                 textBox25.BackColor = Color.RoyalBlue;

             if (textBox26.Text == a[3, 8].ToString())
                 textBox26.BackColor = Color.LightGray;
             else
                 textBox26.BackColor = Color.RoyalBlue;

             if (textBox27.Text == a[3, 9].ToString())
                 textBox27.BackColor = Color.LightGray;
             else
                 textBox27.BackColor = Color.RoyalBlue;

             if (textBox28.Text == a[4, 1].ToString())
                 textBox28.BackColor = Color.LightGray;
             else
                 textBox28.BackColor = Color.RoyalBlue;

             if (textBox29.Text == a[4, 2].ToString())
                 textBox29.BackColor = Color.LightGray;
             else
                 textBox29.BackColor = Color.RoyalBlue;

             if (textBox30.Text == a[4, 3].ToString())
                 textBox30.BackColor = Color.LightGray;
             else
                 textBox30.BackColor = Color.RoyalBlue;

             if (textBox31.Text == a[4, 4].ToString())
                 textBox31.BackColor = Color.LightGray;
             else
                 textBox31.BackColor = Color.RoyalBlue;

             if (textBox32.Text == a[4, 5].ToString())
                 textBox32.BackColor = Color.LightGray;
             else
                 textBox32.BackColor = Color.RoyalBlue;

             if (textBox33.Text == a[4, 6].ToString())
                 textBox33.BackColor = Color.LightGray;
             else
                 textBox33.BackColor = Color.RoyalBlue;

             if (textBox34.Text == a[4, 7].ToString())
                 textBox34.BackColor = Color.LightGray;
             else
                 textBox34.BackColor = Color.RoyalBlue;

             if (textBox35.Text == a[4, 8].ToString())
                 textBox35.BackColor = Color.LightGray;
             else
                 textBox35.BackColor = Color.RoyalBlue;

             if (textBox36.Text == a[4, 9].ToString())
                 textBox36.BackColor = Color.LightGray;
             else
                 textBox36.BackColor = Color.RoyalBlue;

             if (textBox37.Text == a[5, 1].ToString())
                 textBox37.BackColor = Color.LightGray;
             else
                 textBox37.BackColor = Color.RoyalBlue;

             if (textBox38.Text == a[5, 2].ToString())
                 textBox38.BackColor = Color.LightGray;
             else
                 textBox38.BackColor = Color.RoyalBlue;

             if (textBox39.Text == a[5, 3].ToString())
                 textBox39.BackColor = Color.LightGray;
             else
                 textBox39.BackColor = Color.RoyalBlue;

             if (textBox40.Text == a[5, 4].ToString())
                 textBox40.BackColor = Color.LightGray;
             else
                 textBox40.BackColor = Color.RoyalBlue;

             if (textBox41.Text == a[5, 5].ToString())
                 textBox41.BackColor = Color.LightGray;
             else
                 textBox41.BackColor = Color.RoyalBlue;

             if (textBox42.Text == a[5, 6].ToString())
                 textBox42.BackColor = Color.LightGray;
             else
                 textBox42.BackColor = Color.RoyalBlue;

             if (textBox43.Text == a[5, 7].ToString())
                 textBox43.BackColor = Color.LightGray;
             else
                 textBox43.BackColor = Color.RoyalBlue;

             if (textBox44.Text == a[5, 8].ToString())
                 textBox44.BackColor = Color.LightGray;
             else
                 textBox44.BackColor = Color.RoyalBlue;

             if (textBox45.Text == a[5, 9].ToString())
                 textBox45.BackColor = Color.LightGray;
             else
                 textBox45.BackColor = Color.RoyalBlue;

             if (textBox46.Text == a[6, 1].ToString())
                 textBox46.BackColor = Color.LightGray;
             else
                 textBox46.BackColor = Color.RoyalBlue;

             if (textBox47.Text == a[6, 2].ToString())
                 textBox47.BackColor = Color.LightGray;
             else
                 textBox47.BackColor = Color.RoyalBlue;

             if (textBox48.Text == a[6, 3].ToString())
                 textBox48.BackColor = Color.LightGray;
             else
                 textBox48.BackColor = Color.RoyalBlue;

             if (textBox49.Text == a[6, 4].ToString())
                 textBox49.BackColor = Color.LightGray;
             else
                 textBox49.BackColor = Color.RoyalBlue;

             if (textBox50.Text == a[6, 5].ToString())
                 textBox50.BackColor = Color.LightGray;
             else
                 textBox50.BackColor = Color.RoyalBlue;

             if (textBox51.Text == a[6, 6].ToString())
                 textBox51.BackColor = Color.LightGray;
             else
                 textBox51.BackColor = Color.RoyalBlue;

             if (textBox52.Text == a[6, 7].ToString())
                 textBox52.BackColor = Color.LightGray;
             else
                 textBox52.BackColor = Color.RoyalBlue;

             if (textBox53.Text == a[6, 8].ToString())
                 textBox53.BackColor = Color.LightGray;
             else
                 textBox53.BackColor = Color.RoyalBlue;

             if (textBox54.Text == a[6, 9].ToString())
                 textBox54.BackColor = Color.LightGray;
             else
                 textBox54.BackColor = Color.RoyalBlue;

             if (textBox55.Text == a[7, 1].ToString())
                 textBox55.BackColor = Color.LightGray;
             else
                 textBox55.BackColor = Color.RoyalBlue;

             if (textBox56.Text == a[7, 2].ToString())
                 textBox56.BackColor = Color.LightGray;
             else
                 textBox56.BackColor = Color.RoyalBlue;

             if (textBox57.Text == a[7, 3].ToString())
                 textBox57.BackColor = Color.LightGray;
             else
                 textBox57.BackColor = Color.RoyalBlue;

             if (textBox58.Text == a[7, 4].ToString())
                 textBox58.BackColor = Color.LightGray;
             else
                 textBox58.BackColor = Color.RoyalBlue;

             if (textBox59.Text == a[7, 5].ToString())
                 textBox59.BackColor = Color.LightGray;
             else
                 textBox59.BackColor = Color.RoyalBlue;

             if (textBox60.Text == a[7, 6].ToString())
                 textBox60.BackColor = Color.LightGray;
             else
                 textBox60.BackColor = Color.RoyalBlue;
             
             if (textBox61.Text == a[7, 7].ToString())
                 textBox61.BackColor = Color.LightGray;
             else
                 textBox61.BackColor = Color.RoyalBlue;
             
             if (textBox62.Text == a[7, 8].ToString())
                 textBox62.BackColor = Color.LightGray;
             else
                 textBox62.BackColor = Color.RoyalBlue;

             if (textBox63.Text == a[7, 9].ToString())
                 textBox63.BackColor = Color.LightGray;
             else
                 textBox63.BackColor = Color.RoyalBlue;

             if (textBox64.Text == a[8, 1].ToString())
                 textBox64.BackColor = Color.LightGray;
             else
                 textBox64.BackColor = Color.RoyalBlue;

             if (textBox65.Text == a[8, 2].ToString())
                 textBox65.BackColor = Color.LightGray;
             else
                 textBox65.BackColor = Color.RoyalBlue;

             if (textBox66.Text == a[8, 3].ToString())
                 textBox66.BackColor = Color.LightGray;
             else
                 textBox66.BackColor = Color.RoyalBlue;

             if (textBox67.Text == a[8, 4].ToString())
                 textBox67.BackColor = Color.LightGray;
             else
                 textBox67.BackColor = Color.RoyalBlue;

             if (textBox68.Text == a[8, 5].ToString())
                 textBox68.BackColor = Color.LightGray;
             else
                 textBox68.BackColor = Color.RoyalBlue;

             if (textBox69.Text == a[8, 6].ToString())
                 textBox69.BackColor = Color.LightGray;
             else
                 textBox69.BackColor = Color.RoyalBlue;

             if (textBox70.Text == a[8, 7].ToString())
                 textBox70.BackColor = Color.LightGray;
             else
                 textBox70.BackColor = Color.RoyalBlue;

             if (textBox71.Text == a[8, 8].ToString())
                 textBox71.BackColor = Color.LightGray;
             else
                 textBox71.BackColor = Color.RoyalBlue;

             if (textBox72.Text == a[8, 9].ToString())
                 textBox72.BackColor = Color.LightGray;
             else
                 textBox72.BackColor = Color.RoyalBlue;

             if (textBox73.Text == a[9, 1].ToString())
                 textBox73.BackColor = Color.LightGray;
             else
                 textBox73.BackColor = Color.RoyalBlue;

             if (textBox74.Text == a[9, 2].ToString())
                 textBox74.BackColor = Color.LightGray;
             else
                 textBox74.BackColor = Color.RoyalBlue;

             if (textBox75.Text == a[9, 3].ToString())
                 textBox75.BackColor = Color.LightGray;
             else
                 textBox75.BackColor = Color.RoyalBlue;

             if (textBox76.Text == a[9, 4].ToString())
                 textBox76.BackColor = Color.LightGray;
             else
                 textBox76.BackColor = Color.RoyalBlue;

             if (textBox77.Text == a[9, 5].ToString())
                 textBox77.BackColor = Color.LightGray;
             else
                 textBox77.BackColor = Color.RoyalBlue;

             if (textBox78.Text == a[9, 6].ToString())
                 textBox78.BackColor = Color.LightGray;
             else
                 textBox78.BackColor = Color.RoyalBlue;

             if (textBox79.Text == a[9, 7].ToString())
                 textBox79.BackColor = Color.LightGray;
             else
                 textBox79.BackColor = Color.RoyalBlue;

             if (textBox80.Text == a[9, 8].ToString())
                 textBox80.BackColor = Color.LightGray;
             else
                 textBox80.BackColor = Color.RoyalBlue;

             if (textBox81.Text == a[9, 9].ToString())
                 textBox81.BackColor = Color.LightGray;
             else
                 textBox81.BackColor = Color.RoyalBlue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button1.Visible = false;
                        

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            level=1;
            completeaza(level);
            verifica_numere();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 2;
            completeaza(level);
            verifica_numere();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 3;
            completeaza(level);
            verifica_numere();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            level = 1;
            completeaza(level);
            verifica_numere();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            level = 2;
            completeaza(level);
            verifica_numere();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            level = 3;
            completeaza(level);
            verifica_numere();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
                completeaza(level);
                verifica_numere();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verifica_numere();
            if (textBox1.BackColor == Color.LightGray && textBox2.BackColor == Color.LightGray && textBox3.BackColor == Color.LightGray && textBox4.BackColor == Color.LightGray && textBox5.BackColor == Color.LightGray && textBox6.BackColor == Color.LightGray && textBox7.BackColor == Color.LightGray && textBox8.BackColor == Color.LightGray && textBox9.BackColor == Color.LightGray && textBox10.BackColor == Color.LightGray && textBox11.BackColor == Color.LightGray && textBox12.BackColor == Color.LightGray && textBox13.BackColor == Color.LightGray && textBox14.BackColor == Color.LightGray && textBox15.BackColor == Color.LightGray && textBox16.BackColor == Color.LightGray && textBox17.BackColor == Color.LightGray && textBox18.BackColor == Color.LightGray && textBox19.BackColor == Color.LightGray && textBox20.BackColor == Color.LightGray && textBox21.BackColor == Color.LightGray && textBox22.BackColor == Color.LightGray && textBox23.BackColor == Color.LightGray && textBox24.BackColor == Color.LightGray && textBox25.BackColor == Color.LightGray && textBox26.BackColor == Color.LightGray && textBox27.BackColor == Color.LightGray && textBox28.BackColor == Color.LightGray && textBox29.BackColor == Color.LightGray && textBox30.BackColor == Color.LightGray && textBox31.BackColor == Color.LightGray && textBox32.BackColor == Color.LightGray && textBox33.BackColor == Color.LightGray && textBox34.BackColor == Color.LightGray && textBox35.BackColor == Color.LightGray && textBox36.BackColor == Color.LightGray && textBox37.BackColor == Color.LightGray && textBox38.BackColor == Color.LightGray && textBox39.BackColor == Color.LightGray && textBox40.BackColor == Color.LightGray && textBox41.BackColor == Color.LightGray && textBox42.BackColor == Color.LightGray && textBox43.BackColor == Color.LightGray && textBox44.BackColor == Color.LightGray && textBox45.BackColor == Color.LightGray && textBox46.BackColor == Color.LightGray && textBox47.BackColor == Color.LightGray && textBox48.BackColor == Color.LightGray && textBox49.BackColor == Color.LightGray && textBox50.BackColor == Color.LightGray && textBox51.BackColor == Color.LightGray && textBox52.BackColor == Color.LightGray && textBox53.BackColor == Color.LightGray && textBox54.BackColor == Color.LightGray && textBox55.BackColor == Color.LightGray && textBox56.BackColor == Color.LightGray && textBox57.BackColor == Color.LightGray && textBox58.BackColor == Color.LightGray && textBox59.BackColor == Color.LightGray && textBox60.BackColor == Color.LightGray && textBox61.BackColor == Color.LightGray && textBox62.BackColor == Color.LightGray && textBox63.BackColor == Color.LightGray && textBox64.BackColor == Color.LightGray && textBox65.BackColor == Color.LightGray && textBox66.BackColor == Color.LightGray && textBox67.BackColor == Color.LightGray && textBox68.BackColor == Color.LightGray && textBox69.BackColor == Color.LightGray && textBox70.BackColor == Color.LightGray && textBox71.BackColor == Color.LightGray && textBox72.BackColor == Color.LightGray && textBox73.BackColor == Color.LightGray && textBox74.BackColor == Color.LightGray && textBox75.BackColor == Color.LightGray && textBox76.BackColor == Color.LightGray && textBox77.BackColor == Color.LightGray && textBox78.BackColor == Color.LightGray && textBox79.BackColor == Color.LightGray && textBox80.BackColor == Color.LightGray && textBox81.BackColor == Color.LightGray)
            {
                MessageBox.Show("Congratulation!");
                button5.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;
                textBox25.Enabled = false;
                textBox26.Enabled = false;
                textBox27.Enabled = false;
                textBox28.Enabled = false;
                textBox29.Enabled = false;
                textBox30.Enabled = false;
                textBox31.Enabled = false;
                textBox32.Enabled = false;
                textBox33.Enabled = false;
                textBox34.Enabled = false;
                textBox35.Enabled = false;
                textBox36.Enabled = false;
                textBox37.Enabled = false;
                textBox38.Enabled = false;
                textBox39.Enabled = false;
                textBox40.Enabled = false;
                textBox41.Enabled = false;
                textBox42.Enabled = false;
                textBox43.Enabled = false;
                textBox44.Enabled = false;
                textBox45.Enabled = false;
                textBox46.Enabled = false;
                textBox47.Enabled = false;
                textBox48.Enabled = false;
                textBox49.Enabled = false;
                textBox50.Enabled = false;
                textBox51.Enabled = false;
                textBox52.Enabled = false;
                textBox53.Enabled = false;
                textBox54.Enabled = false;
                textBox55.Enabled = false;
                textBox56.Enabled = false;
                textBox57.Enabled = false;
                textBox58.Enabled = false;
                textBox59.Enabled = false;
                textBox60.Enabled = false;
                textBox61.Enabled = false;
                textBox62.Enabled = false;
                textBox63.Enabled = false;
                textBox64.Enabled = false;
                textBox65.Enabled = false;
                textBox66.Enabled = false;
                textBox67.Enabled = false;
                textBox68.Enabled = false;
                textBox69.Enabled = false;
                textBox70.Enabled = false;
                textBox71.Enabled = false;
                textBox72.Enabled = false;
                textBox73.Enabled = false;
                textBox74.Enabled = false;
                textBox75.Enabled = false;
                textBox76.Enabled = false;
                textBox77.Enabled = false;
                textBox78.Enabled = false;
                textBox79.Enabled = false;
                textBox80.Enabled = false;
                textBox81.Enabled = false;
            }
        }  
    }
}
