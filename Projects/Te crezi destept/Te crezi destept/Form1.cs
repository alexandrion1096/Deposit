using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Te_crezi_destept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int v = 1, p = 1, c = 0, nivel = 0;


        void detoate()
        {


            label1.Text = "Numele jucatorului!";
            label3.Text = textBox2.Text;
            textBox2.Visible = false;
            label3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label2.Visible = true;
            label2.Enabled = true;
            button3.Visible = true; ;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            textBox2.Enabled = false;
            if (p == 7)
            {
                label2.Text = "7) Cine este presedintele romaniei?";
                radioButton1.Text = "Traian Basescu";
                radioButton2.Text = "Victor Ponta";
                radioButton3.Text = "Klaus Iohannis";
                radioButton4.Text = "Niciunul";
                p++;
            }
            else
                if (p == 6)
                {
                    label2.Text = "6) Care este capitala Romaniei?";
                    radioButton1.Text = "Atena";
                    radioButton2.Text = "Bucuresti";
                    radioButton3.Text = "Baia Mare";
                    radioButton4.Text = "Cluj-Napoca";
                    p++;
                }
                else
                    if (p == 10)
                    {
                        label2.Text = "10) Steagul Romaniei contine Culorile:";

                        radioButton1.Text = "Rosu,Galben,Albastru";
                        radioButton2.Text = "Rosu,Galben,Verde";
                        radioButton3.Text = "Verde,Alb,Rosu";
                        radioButton4.Text = "Alb,Albastru,Rosu";
                    }
                    else
                        if (p == 3)
                        {
                            label2.Text = "3) Octavia este modelul fabricat de catre?";

                            radioButton1.Text = "Fiat";
                            radioButton2.Text = "Mazda";
                            radioButton3.Text = "Dacia";
                            radioButton4.Text = "Skoda";
                            p++;
                        }
                        else
                            if (p == 5)
                            {
                                label2.Text = "5) Care dintre cele doua orase are cei mai multi locuitori?";

                                radioButton1.Text = "Londra";
                                radioButton2.Text = "Istambul";
                                radioButton3.Text = "Madrid";
                                radioButton4.Text = "Budapesta";
                                p++;
                            }
                            else
                                if (p == 4)
                                {
                                    label2.Text = "4) Actorul Jean-Claude Van Damme este de origine?";

                                    radioButton1.Text = "Elvetian";
                                    radioButton2.Text = "Francez";
                                    radioButton3.Text = "Belgian";
                                    radioButton4.Text = "German";
                                    p++;
                                }
                                else
                                    if (p == 2)
                                    {
                                        label2.Text = "2) Care este valoarea literei e?";

                                        radioButton1.Text = "2,71";
                                        radioButton2.Text = "3,14";
                                        radioButton3.Text = "2,17";
                                        radioButton4.Text = "4,13";
                                        p++;
                                    }
                                    else

                                        if (p == 9)
                                        {
                                            label2.Text = "9) Romania a intrat in NATO la data de?";

                                            radioButton1.Text = " 29 martie 2004";
                                            radioButton2.Text = "1 ianuarie 2002";
                                            radioButton3.Text = "13 septembrie 2005";
                                            radioButton4.Text = "29 august 1999";
                                            p++;
                                        }
                                        else
                                            if (p == 8)
                                            {
                                                label2.Text = "8) Cine este solistul trupei VAMA?";

                                                radioButton1.Text = "Cristi Enache";
                                                radioButton2.Text = "Stefan Banica";
                                                radioButton3.Text = "Tudor Chirila";
                                                radioButton4.Text = "Horia Brenciu";
                                                p++;
                                            }
                                            else
                                                if (p == 1)
                                                {
                                                    label2.Text = "1) In limbajul c++ expresia:d=d+1,este echivalenta cu:";

                                                    radioButton1.Text = "d=+1;";
                                                    radioButton2.Text = "d+=1;";
                                                    radioButton3.Text = "1+d";
                                                    radioButton4.Text = "d+1";
                                                    p++;

                                                }
        }

        void TIC()
        {
            label1.Text = "Numele jucatorului!";
            label3.Text = textBox2.Text;
            textBox2.Visible = false;
            label3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label2.Visible = true;
            label2.Enabled = true;
            button3.Visible = true; ;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            textBox2.Enabled = false;
            if (p == 1)
            {
                label2.Text = "1) 1 GB este egal cu:";
                radioButton1.Text = "1024 Byte";
                radioButton2.Text = "1024 MByte";
                radioButton3.Text = "1024 KByte";
                radioButton4.Text = "1024 TByte";
                p++;
            }
            else
                if (p == 2)
                {
                    label2.Text = "2) 1 MB este egal cu:";
                    radioButton1.Text = "1024 Byte";
                    radioButton2.Text = "1024 TByte";
                    radioButton3.Text = "1024 GByte";
                    radioButton4.Text = "1024 KByte";
                    p++;
                }
                else
                    if (p == 3)
                    {
                        label2.Text = "3) Windows XP este:";

                        radioButton1.Text = "Un program de calcul tabelar";
                        radioButton2.Text = "Un sistem de operare";
                        radioButton3.Text = "Un calculator personal";
                        radioButton4.Text = "Un tip de mouse";
                        p++;
                    }
                    else
                        if (p == 4)
                        {
                            label2.Text = "4) Principala caracteristica a Hard disk-ului este:";

                            radioButton1.Text = "Frecventa";
                            radioButton2.Text = "Capacitatea de stocare";
                            radioButton3.Text = "Rezolutia";
                            radioButton4.Text = "Contrastul";
                            p++;
                        }
                        else
                            if (p == 5)
                            {
                                label2.Text = "5) Capacitatea unui DVD este de:";

                                radioButton1.Text = "4.7 GByte";
                                radioButton2.Text = "4.7 MByte";
                                radioButton3.Text = "4.7 TByte";
                                radioButton4.Text = "4.7 KByte";
                                p++;
                            }
                            else
                                if (p == 6)
                                {
                                    label2.Text = "6)Pentru a închide aplicatia Word alegem din meniu optiunea:";

                                    radioButton1.Text = "File-Save (Fisier - Salvare)";
                                    radioButton2.Text = "File-Close (Fisier - Închidere)";
                                    radioButton3.Text = "File-Exit (Fisier - Iesire)";
                                    radioButton4.Text = "File-Open (Fisier - Deschidere)";
                                    p++;
                                }
                                else
                                    if (p == 7)
                                    {
                                        label2.Text = "7) Care dintre dispozitivele de mai jos sunt de iesire:";

                                        radioButton1.Text = "Mouse-ul";
                                        radioButton2.Text = "Tastatura";
                                        radioButton3.Text = "Monitorul";
                                        radioButton4.Text = "CD-ul";
                                        p++;
                                    }
                                    else

                                        if (p == 8)
                                        {
                                            label2.Text = "8) Dimensiunea diagonalei monitoarelor se masoara în:";

                                            radioButton1.Text = "Inch";
                                            radioButton2.Text = "Pixeli";
                                            radioButton3.Text = "Hz";
                                            radioButton4.Text = "Centimetrii";
                                            p++;
                                        }
                                        else
                                            if (p == 9)
                                            {
                                                label2.Text = "9) Desktop este:";

                                                radioButton1.Text = "Un program";
                                                radioButton2.Text = "O caracteristica a monitorului";
                                                radioButton3.Text = "Suprafata de lucru din Windows";
                                                radioButton4.Text = "Un mediu de stocare";
                                                p++;
                                            }
                                            else
                                                if (p == 10)
                                                {
                                                    label2.Text = "10) Programul Microsoft Word este:";

                                                    radioButton1.Text = "Un procesor de texte";
                                                    radioButton2.Text = "Un program de calcul tabelar";
                                                    radioButton3.Text = "Un editor de imagini";
                                                    radioButton4.Text = "Un sistem de operare";
                                                }
        }
        void matematica()
        {
            label1.Text = "Numele jucatorului!";
            label3.Text = textBox2.Text;
            textBox2.Visible = false;
            label3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label2.Visible = true;
            label2.Enabled = true;
            button3.Visible = true; ;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            textBox2.Enabled = false;
            if (p == 1)
            {
                label2.Text ="1) Care este cel de-al 10-lea termen al şirului 1,3,5,7,...?";
                radioButton1.Text = "17";
                radioButton2.Text = "19";
                radioButton3.Text = "18";
                radioButton4.Text = "21";
                p++;
            }
            else
                if (p == 2)
                {
                    label2.Text = "2) Efectuand: 9+40{-18-[4+7]},obtinem:";
                    radioButton1.Text = "30";
                    radioButton2.Text = "31";
                    radioButton3.Text = "20";
                    radioButton4.Text = "42";
                    p++;
                }
                else
                    if (p == 3)
                    {
                        label2.Text = "3) cmmmc al numerelor 2 si 12 este:";

                        radioButton1.Text = "4";
                        radioButton2.Text = "2";
                        radioButton3.Text = "3";
                        radioButton4.Text = "6";
                        p++;
                    }
                    else
                        if (p == 4)
                        {
                            label2.Text = "4) Cel mai mare numar prim de 3 cifre este:";

                            radioButton1.Text = "999";
                            radioButton2.Text = "997";
                            radioButton3.Text = "998";
                            radioButton4.Text = "889";
                            p++;
                        }
                        else
                            if (p == 5)
                            {
                                label2.Text = "5) Daca lg(x+33-23)=1,atunci x este:";

                                radioButton1.Text = "0";
                                radioButton2.Text = "10";
                                radioButton3.Text = "6";
                                radioButton4.Text = "1";
                                p++;
                            }
                            else
                                if (p == 6)
                                {
                                    label2.Text = "6) Ce numar urmeaza in sirul: 17,27,47,57,77,87...?";
                                    radioButton1.Text = "97";
                                    radioButton2.Text = "107";
                                    radioButton3.Text = "117";
                                    radioButton4.Text = "127";
                                    p++;
                                }
                                else
                                    if (p == 7)
                                    {
                                        label2.Text = "7) cmmdc al numerelor 8 si 45 este";
                                        radioButton1.Text = "5";
                                        radioButton2.Text = "8";
                                        radioButton3.Text = "1";
                                        radioButton4.Text = "45";
                                        p++;
                                    }
                                    else

                                        if (p == 8)
                                        {
                                            label2.Text = "8) Care dintre numere este liber de patrate?";

                                            radioButton1.Text = "5";
                                            radioButton2.Text = "8";
                                            radioButton3.Text = "12";
                                            radioButton4.Text = "4";
                                            p++;
                                        }
                                        else
                                            if (p == 9)
                                            {
                                                label2.Text = "9) Fie l-numarul de linii si c-numarul de coloane,matricea patratica are:";

                                                radioButton1.Text = "l>c";
                                                radioButton2.Text = "l<c";
                                                radioButton3.Text = "l=c";
                                                radioButton4.Text = "l-1=c";
                                                p++;
                                            }
                                            else
                                                if (p == 10)
                                                {
                                                    label2.Text = "10) Restul impartirii pilinomului x-5,la x+2,este:";

                                                    radioButton1.Text = "-7";
                                                    radioButton2.Text = "7";
                                                    radioButton3.Text = "3";
                                                    radioButton4.Text = "1";
                                                }
        }
        void fizica()
        {
            label1.Text = "Numele jucatorului!";
            label3.Text = textBox2.Text;
            textBox2.Visible = false;
            label3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label2.Visible = true;
            label2.Enabled = true;
            button3.Visible = true; ;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            textBox2.Enabled = false;
            if (p == 1)
            {
                label2.Text = "1) Viteza luminii in vid este aproximativ?";
                radioButton1.Text = "3.000.000.000 m/2";
                radioButton2.Text = "300.000.000 m/s";
                radioButton3.Text = "200.000 m/s";
                radioButton4.Text = "1.000.000.000 km/h";
                p++;
            }
            else
                if (p == 2)
                {
                    label2.Text = "2) Impulsul poate fi exprimat cantitativ prin formula:";
                    radioButton1.Text = "p=mv";
                    radioButton2.Text = "P=mV";
                    radioButton3.Text = "G=mg";
                    radioButton4.Text = "Nu exista";
                    p++;
                }
                else
                    if (p == 3)
                    {
                        label2.Text = "3) Greutatea unui corp se calculeaza dupa formula:";

                        radioButton1.Text = "G=hv";
                        radioButton2.Text = "G=mh";
                        radioButton3.Text = "g=mh";
                        radioButton4.Text = "G=mg";
                        p++;
                    }
                    else
                        if (p == 4)
                        {
                            label2.Text = "4) 1 Kg este echivalent cu:";

                            radioButton1.Text = "100 decagrame (dag)";
                            radioButton2.Text = "1.000 decigrame(dg)";
                            radioButton3.Text = "100.000 centigrame (cg)";
                            radioButton4.Text = "10 hectograme(hg)";
                            p++;
                        }
                        else
                            if (p == 5)
                            {
                                label2.Text = "5) Unitatea de masura amasei unui corp este:";

                                radioButton1.Text = "1 tona(t)";
                                radioButton2.Text = "1 kilogram(kg)";
                                radioButton3.Text = "1 gram(g)";
                                radioButton4.Text = "1 chintal(q)";
                                p++;
                            }
                            else
                                if (p == 6)
                                {
                                    label2.Text = "6) Lucrul mecanic (L) se masoara in:";

                                    radioButton1.Text = "metri (m)";
                                    radioButton2.Text = "joule (J)";
                                    radioButton3.Text = "pascali (Pa)";
                                    radioButton4.Text = "volti (V)";
                                    p++;
                                }
                                else
                                    if (p == 7)
                                    {
                                        label2.Text = "7) Acceleratia gravitationala este egala cu?";

                                        radioButton1.Text = "g=9,9 m/s";
                                        radioButton2.Text = "g=8,9 m/s";
                                        radioButton3.Text = "g=9,8 m/s";
                                        radioButton4.Text = "g=10 m/s";
                                        p++;
                                    }
                                    else

                                        if (p == 8)
                                        {
                                            label2.Text = "8) Din formula presiunii hidrostatice, p=qgh, q reprezinta";

                                            radioButton1.Text = "Acceleratia gravitationala";
                                            radioButton2.Text = "Inaltimea coloanei de fluid";
                                            radioButton3.Text = "Densitatea fluidului";
                                            radioButton4.Text = "Caldura lichidului";
                                            p++;
                                        }
                                        else
                                            if (p == 9)
                                            {
                                                label2.Text = "9) Un grad Celsius(C) are:";

                                                radioButton1.Text = "273,16 grade Kelvin";
                                                radioButton2.Text = "237,16 grade Kelvin";
                                                radioButton3.Text = "723,16 grade Kelvin";
                                                radioButton4.Text = "327,26 grade Kelvin";
                                                p++;
                                            }
                                            else
                                                if (p == 10)
                                                {
                                                    label2.Text = "10) Procesul de trecere din stare solida in stare gazoasa se numeste:";

                                                    radioButton1.Text = "Sublimare";
                                                    radioButton2.Text = "Condensar;";
                                                    radioButton3.Text = "Solidificare";
                                                    radioButton4.Text = "Vaporizare";

                                                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            label2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            
            if (nivel == 1)
            {
                if (v == 1)
                {
                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                    { MessageBox.Show("Nu ati dat nici un raspuns!");
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    button3.Enabled = true;
                    label2.Enabled = true;
                    }
                    else
                        if (radioButton2.Checked)
                        {
                            c++;
                            detoate();
                            v++;
                        }
                        else
                        { detoate();
                        v++;
                        }
                }
                else
                    if (v == 2)
                    {
                        if (radioButton1.Checked)
                        {

                            c++;
                            detoate();
                            v++;
                        }

                        else
                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                            {
                                MessageBox.Show("Nu ati dat nici un raspuns!");
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                                radioButton3.Enabled = true;
                                radioButton4.Enabled = true;
                                button3.Enabled = true;
                                label2.Enabled = true;
                            }

                            else
                            { detoate();
                            v++;
                            }
                    }
                    else
                        if (v == 3)
                        {
                            if (radioButton4.Checked)
                            {

                                c++;
                                detoate();
                                v++;
                            }
                            else
                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                {
                                    MessageBox.Show("Nu ati dat nici un raspuns!");
                                    radioButton1.Enabled = true;
                                    radioButton2.Enabled = true;
                                    radioButton3.Enabled = true;
                                    radioButton4.Enabled = true;
                                    button3.Enabled = true;
                                    label2.Enabled = true;
                                }
                                else
                                {
                                    detoate();
                                    v++;
                                }
                        }

                        else
                            if (v == 4)
                            {
                                if (radioButton3.Checked)
                                {

                                    c++;

                                    detoate();
                                    v++;
                                }
                                else
                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                    {
                                        MessageBox.Show("Nu ati dat nici un raspuns!");
                                        radioButton1.Enabled = true;
                                        radioButton2.Enabled = true;
                                        radioButton3.Enabled = true;
                                        radioButton4.Enabled = true;
                                        button3.Enabled = true;
                                        label2.Enabled = true;
                                    }

                                    else
                                    { detoate();
                                    v++;
                                    }
                            }
                            else
                                if (v == 5)
                                {
                                    if (radioButton2.Checked)
                                    {

                                        c++;
                                        detoate();
                                        v++;
                                    }
                                    else
                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                        {
                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                            radioButton1.Enabled = true;
                                            radioButton2.Enabled = true;
                                            radioButton3.Enabled = true;
                                            radioButton4.Enabled = true;
                                            button3.Enabled = true;
                                            label2.Enabled = true;
                                        }
                                        else
                                        { detoate();
                                        v++;
                                        }
                                }
                                else
                                    if (v == 6)
                                    {
                                        if (radioButton2.Checked)
                                        {

                                            c++;
                                            detoate();
                                            v++;
                                        }
                                        else
                                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                            {
                                                MessageBox.Show("Nu ati dat nici un raspuns!");
                                                radioButton1.Enabled = true;
                                                radioButton2.Enabled = true;
                                                radioButton3.Enabled = true;
                                                radioButton4.Enabled = true;
                                                button3.Enabled = true;
                                                label2.Enabled = true;
                                            }
                                            else
                                            {
                                                detoate();
                                                v++;
                                            }
                                    }
                                    else
                                        if (v == 7)
                                        {
                                            if (radioButton3.Checked)
                                            {

                                                c++;
                                                detoate();
                                                v++;
                                            }
                                            else
                                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                {
                                                    MessageBox.Show("Nu ati dat nici un raspuns!");
                                                    radioButton1.Enabled = true;
                                                    radioButton2.Enabled = true;
                                                    radioButton3.Enabled = true;
                                                    radioButton4.Enabled = true;
                                                    button3.Enabled = true;
                                                    label2.Enabled = true;
                                                }
                                                else
                                                {
                                                    detoate();
                                                    v++;
                                                }
                                        }

                                        else
                                            if (v == 8)
                                            {
                                                if (radioButton3.Checked)
                                                {

                                                    c++;
                                                    detoate();
                                                    v++;
                                                }
                                                else
                                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                    {
                                                        MessageBox.Show("Nu ati dat nici un raspuns!");
                                                        radioButton1.Enabled = true;
                                                        radioButton2.Enabled = true;
                                                        radioButton3.Enabled = true;
                                                        radioButton4.Enabled = true;
                                                        button3.Enabled = true;
                                                        label2.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        detoate();
                                                        v++;
                                                    }
                                            }
                                            else
                                                if (v == 9)
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                                                        detoate();
                                                        v++;
                                                    }
                                                    else
                                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                        {
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                                            radioButton1.Enabled = true;
                                                            radioButton2.Enabled = true;
                                                            radioButton3.Enabled = true;
                                                            radioButton4.Enabled = true;
                                                            button3.Enabled = true;
                                                            label2.Enabled = true;
                                                        }
                                                        else
                                                        {
                                                            detoate();
                                                            v++;
                                                        }

                                                }
                                                else
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                            
                                                    }
                                                    else
                                                        if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                                                        {
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                                            radioButton1.Enabled = true;
                                                            radioButton2.Enabled = true;
                                                            radioButton3.Enabled = true;
                                                            radioButton4.Enabled = true;
                                                            button3.Enabled = true;
                                                            label2.Enabled = true;
                                                        }
                                                    radioButton1.Enabled = false;
                                                    radioButton2.Enabled = false;
                                                    radioButton3.Enabled = false;
                                                    radioButton4.Enabled = false;
                                                    button3.Enabled = false;
                                                    label2.Enabled = false;
                                                    MessageBox.Show("Jocul s-a terminat!");
                                                    MessageBox.Show(" Bravo " + textBox2.Text + " " + "ai raspuns corect la" + " " + c + "  " + "intrebari din 10!");
                                                }
            }
            if (nivel == 2)
            {
                if (v == 1)
                {
                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                    { MessageBox.Show("Nu ati dat nici un raspuns!"); }
                    else
                        if (radioButton2.Checked)
                        {
                            c++;
                        }
                    TIC();
                    v++;
                }
                else
                    if (v == 2)
                    {
                        if (radioButton4.Checked)
                        {

                            c++;
                        }

                        else
                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                MessageBox.Show("Nu ati dat nici un raspuns!");

                        TIC();
                        v++;
                    }
                    else
                        if (v == 3)
                        {
                            if (radioButton2.Checked)
                            {

                                c++;
                            }
                            else
                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                    MessageBox.Show("Nu ati dat nici un raspuns!");

                            TIC();
                            v++;

                        }

                        else
                            if (v == 4)
                            {
                                if (radioButton2.Checked)
                                {

                                    c++;
                                }
                                else
                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                        MessageBox.Show("Nu ati dat nici un raspuns!");

                                TIC();
                                v++;

                            }
                            else
                                if (v == 5)
                                {
                                    if (radioButton1.Checked)
                                    {

                                        c++;
                                    }
                                    else
                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                    TIC();
                                    v++;

                                }
                                else
                                    if (v == 6)
                                    {
                                        if (radioButton2.Checked)
                                        {

                                            c++;
                                        }
                                        else
                                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                MessageBox.Show("Nu ati dat nici un raspuns!");
                                        TIC();
                                        v++;

                                    }
                                    else
                                        if (v == 7)
                                        {
                                            if (radioButton3.Checked)
                                            {

                                                c++;
                                            }
                                            else
                                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                    MessageBox.Show("Nu ati dat nici un raspuns!");
                                            TIC();
                                            v++;

                                        }

                                        else
                                            if (v == 8)
                                            {
                                                if (radioButton1.Checked)
                                                {

                                                    c++;
                                                }
                                                else
                                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                        MessageBox.Show("Nu ati dat nici un raspuns!");
                                                TIC();
                                                v++;

                                            }
                                            else
                                                if (v == 9)
                                                {
                                                    if (radioButton3.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    TIC();
                                                    v++;
                                                }
                                                else
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    MessageBox.Show("Jocul s-a terminat!");
                                                    MessageBox.Show(" Bravo " + textBox2.Text + " " + "ai raspuns corect la" + " " + c + "  " + "intrebari din 10!");
                                                }
            }
            if (nivel == 3)
            {
                if (v == 1)
                {
                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                    { MessageBox.Show("Nu ati dat nici un raspuns!"); }
                    else
                        if (radioButton2.Checked)
                        {
                            c++;
                        }
                    matematica();
                    v++;
                }
                else
                    if (v == 2)
                    {
                        if (radioButton4.Checked)
                        {

                            c++;
                        }

                        else
                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                MessageBox.Show("Nu ati dat nici un raspuns!");

                        matematica();
                        v++;
                    }
                    else
                        if (v == 3)
                        {
                            if (radioButton2.Checked)
                            {

                                c++;
                            }
                            else
                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                    MessageBox.Show("Nu ati dat nici un raspuns!");

                            matematica();
                            v++;

                        }

                        else
                            if (v == 4)
                            {
                                if (radioButton2.Checked)
                                {

                                    c++;
                                }
                                else
                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                        MessageBox.Show("Nu ati dat nici un raspuns!");

                                matematica();
                                v++;

                            }
                            else
                                if (v == 5)
                                {
                                    if (radioButton1.Checked)
                                    {

                                        c++;
                                    }
                                    else
                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                    matematica();
                                    v++;

                                }
                                else
                                    if (v == 6)
                                    {
                                        if (radioButton2.Checked)
                                        {

                                            c++;
                                        }
                                        else
                                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                MessageBox.Show("Nu ati dat nici un raspuns!");
                                        matematica();
                                        v++;

                                    }
                                    else
                                        if (v == 7)
                                        {
                                            if (radioButton3.Checked)
                                            {

                                                c++;
                                            }
                                            else
                                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                    MessageBox.Show("Nu ati dat nici un raspuns!");
                                            matematica();
                                            v++;

                                        }

                                        else
                                            if (v == 8)
                                            {
                                                if (radioButton1.Checked)
                                                {

                                                    c++;
                                                }
                                                else
                                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                        MessageBox.Show("Nu ati dat nici un raspuns!");
                                                matematica();
                                                v++;

                                            }
                                            else
                                                if (v == 9)
                                                {
                                                    if (radioButton3.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    matematica();
                                                    v++;
                                                }
                                                else
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    MessageBox.Show("Jocul s-a terminat!");
                                                    MessageBox.Show(" Bravo " + textBox2.Text + " " + "ai raspuns corect la" + " " + c + "  " + "intrebari din 10!");
                                                }
            }
            if (nivel == 4)
            {
                if (v == 1)
                {
                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                    { MessageBox.Show("Nu ati dat nici un raspuns!"); }
                    else
                        if (radioButton2.Checked)
                        {
                            c++;
                        }
                    fizica();
                    v++;
                }
                else
                    if (v == 2)
                    {
                        if (radioButton1.Checked)
                        {

                            c++;
                        }

                        else
                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                MessageBox.Show("Nu ati dat nici un raspuns!");

                        fizica();
                        v++;
                    }
                    else
                        if (v == 3)
                        {
                            if (radioButton4.Checked)
                            {

                                c++;
                            }
                            else
                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                    MessageBox.Show("Nu ati dat nici un raspuns!");

                            fizica();
                            v++;

                        }

                        else
                            if (v == 4)
                            {
                                if (radioButton3.Checked)
                                {

                                    c++;
                                }
                                else
                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                        MessageBox.Show("Nu ati dat nici un raspuns!");

                                fizica();
                                v++;

                            }
                            else
                                if (v == 5)
                                {
                                    if (radioButton2.Checked)
                                    {

                                        c++;
                                    }
                                    else
                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                            MessageBox.Show("Nu ati dat nici un raspuns!");
                                    fizica();
                                    v++;

                                }
                                else
                                    if (v == 6)
                                    {
                                        if (radioButton2.Checked)
                                        {

                                            c++;
                                        }
                                        else
                                            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                MessageBox.Show("Nu ati dat nici un raspuns!");
                                        fizica();
                                        v++;

                                    }
                                    else
                                        if (v == 7)
                                        {
                                            if (radioButton3.Checked)
                                            {

                                                c++;
                                            }
                                            else
                                                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                    MessageBox.Show("Nu ati dat nici un raspuns!");
                                            fizica();
                                            v++;

                                        }

                                        else
                                            if (v == 8)
                                            {
                                                if (radioButton3.Checked)
                                                {

                                                    c++;
                                                }
                                                else
                                                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                        MessageBox.Show("Nu ati dat nici un raspuns!");
                                                fizica();
                                                v++;

                                            }
                                            else
                                                if (v == 9)
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    fizica();
                                                    v++;
                                                }
                                                else
                                                {
                                                    if (radioButton1.Checked)
                                                    {

                                                        c++;
                                                    }
                                                    else
                                                        if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                                                            MessageBox.Show("Nu ati dat nici un raspuns!");

                                                    MessageBox.Show("Jocul s-a terminat!");
                                                    MessageBox.Show(" Bravo " + textBox2.Text + " " + "ai raspuns corect la" + " " + c + "  " + "intrebari din 10!");
                                                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button4.Visible = false;
            MessageBox.Show("Introduceti numele dunmeavoastra!");
        }



        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = 1;
            v = 1;
            c = 0;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            textBox2.Text = "";
            textBox2.Enabled = true;
            label3.Visible = false;
            label1.Visible = false;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesta este un joc de cultura generala."
                             + "Este posibil ca la anumite intrebari sa existe mai multe variante corecte"
                             + ",insa doar una  poate fi selectata!"
                             + "Succes!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nivel = 1;
            detoate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nivel = 2;
            TIC();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nivel = 3;
            matematica();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nivel = 4;
            fizica();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

      
    }  
    }

