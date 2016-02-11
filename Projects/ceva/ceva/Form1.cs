using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ceva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x % 2!=0)
            {
                x = 2;
                button1.BackColor = Color.Chocolate; 
            }
            else
            {
                button1.BackColor = Color.Crimson;
                x = 1;
            }
            }


        
    }
}
