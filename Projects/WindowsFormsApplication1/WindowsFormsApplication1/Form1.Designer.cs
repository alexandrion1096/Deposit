namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectHomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(1, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(45, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(89, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 39);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(650, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 39);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(172, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 149);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(686, 236);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideHistoryToolStripMenuItem,
            this.addTagToolStripMenuItem,
            this.removeTagToolStripMenuItem,
            this.selectHomePageToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showHideHistoryToolStripMenuItem
            // 
            this.showHideHistoryToolStripMenuItem.Name = "showHideHistoryToolStripMenuItem";
            this.showHideHistoryToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.showHideHistoryToolStripMenuItem.Text = "Show/Hide history";
            this.showHideHistoryToolStripMenuItem.Click += new System.EventHandler(this.showHideHistoryToolStripMenuItem_Click);
            // 
            // addTagToolStripMenuItem
            // 
            this.addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            this.addTagToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.addTagToolStripMenuItem.Text = "Add Tag";
            this.addTagToolStripMenuItem.Click += new System.EventHandler(this.addTagToolStripMenuItem_Click);
            // 
            // removeTagToolStripMenuItem
            // 
            this.removeTagToolStripMenuItem.Name = "removeTagToolStripMenuItem";
            this.removeTagToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.removeTagToolStripMenuItem.Text = "Remove Tag";
            this.removeTagToolStripMenuItem.Click += new System.EventHandler(this.removeTagToolStripMenuItem_Click);
            // 
            // selectHomePageToolStripMenuItem
            // 
            this.selectHomePageToolStripMenuItem.Name = "selectHomePageToolStripMenuItem";
            this.selectHomePageToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.selectHomePageToolStripMenuItem.Text = "Select home page";
            this.selectHomePageToolStripMenuItem.Click += new System.EventHandler(this.selectHomePageToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(172, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Teal;
            this.button5.Location = new System.Drawing.Point(128, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 39);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 359);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTagToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem selectHomePageToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
    }
}

