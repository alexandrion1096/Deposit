using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h = 1;
        public void search()
        {
            webBrowser1.Navigate(textBox1.Text);
            button3.Enabled = true;
            button4.Enabled = false;
            textBox1.Enabled = false;
            if (richTextBox1.Text!=textBox1.Text)
            {
                richTextBox1.AppendText(textBox1.Text);
                richTextBox1.AppendText("\n");
            }
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Type the homepage here!";
            webBrowser1.Navigate("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            textBox1.Text = "";
            textBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Enabled = true; ;
            button4.Enabled = true ;
            button3.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                search();
            }
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add("New Tab");
        }

        private void removeTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }

        private void showHideHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (h == 1)
            {
                richTextBox1.Visible = true;
                h = 0;
            }
            else
            {
                richTextBox1.Visible = false;
                h = 1;
            }
            }

        private void selectHomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Enabled = true;
            textBox2.Text = "Type the homepage here!";
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Enabled = false;
                textBox2.Visible = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Type the homepage here!")
            {
                webBrowser1.Navigate(textBox2.Text);
                textBox1.Text = textBox2.Text;            
            }
            else
            {
                webBrowser1.Navigate("www.google.com");
                textBox1.Text = "www.google.com";
            }
        }

      
    }
}
