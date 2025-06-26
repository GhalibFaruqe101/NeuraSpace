using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NeuraSpace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            user_name = new TextBox();
            user_password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            Admin_panel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(542, 117);
            label1.Name = "label1";
            label1.Size = new Size(291, 64);
            label1.TabIndex = 0;
            label1.Text = "NueraSpace";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowText;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(540, 220);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(540, 336);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.SteelBlue;
            checkBox1.Location = new Point(542, 453);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 30);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Remeber\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(478, 640);
            label6.Name = "label6";
            label6.Size = new Size(264, 28);
            label6.TabIndex = 8;
            label6.Text = "Don't have any account?";
            label6.Click += label6_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.MistyRose;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.SteelBlue;
            linkLabel1.Location = new Point(736, 643);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.VisitedLinkColor = Color.FromArgb(0, 192, 0);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // user_name
            // 
            user_name.BackColor = Color.Black;
            user_name.BorderStyle = BorderStyle.None;
            user_name.Cursor = Cursors.IBeam;
            user_name.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_name.ForeColor = SystemColors.InactiveCaption;
            user_name.Location = new Point(542, 264);
            user_name.Margin = new Padding(6);
            user_name.Name = "user_name";
            user_name.PlaceholderText = "Enter Username";
            user_name.Size = new Size(235, 28);
            user_name.TabIndex = 10;
            user_name.TextChanged += textBox3_TextChanged;
            // 
            // user_password
            // 
            user_password.BackColor = Color.Black;
            user_password.BorderStyle = BorderStyle.None;
            user_password.Cursor = Cursors.IBeam;
            user_password.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_password.ForeColor = SystemColors.InactiveCaption;
            user_password.Location = new Point(540, 383);
            user_password.Name = "user_password";
            user_password.PlaceholderText = "Enter Password";
            user_password.Size = new Size(235, 28);
            user_password.TabIndex = 11;
            user_password.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.HighlightText;
            label4.Font = new Font("Segoe UI", 1F, FontStyle.Bold);
            label4.Location = new Point(542, 296);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(238, 2);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.HighlightText;
            label5.Font = new Font("Segoe UI", 1F, FontStyle.Bold);
            label5.Location = new Point(542, 415);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(238, 2);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(576, 520);
            button1.Name = "button1";
            button1.Size = new Size(184, 61);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Admin_panel
            // 
            Admin_panel.ActiveLinkColor = Color.MistyRose;
            Admin_panel.AutoSize = true;
            Admin_panel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_panel.LinkBehavior = LinkBehavior.NeverUnderline;
            Admin_panel.LinkColor = Color.SteelBlue;
            Admin_panel.Location = new Point(610, 720);
            Admin_panel.Name = "Admin_panel";
            Admin_panel.Size = new Size(71, 25);
            Admin_panel.TabIndex = 16;
            Admin_panel.TabStop = true;
            Admin_panel.Text = "Admin";
            Admin_panel.VisitedLinkColor = Color.FromArgb(0, 192, 0);
            Admin_panel.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 861);
            Controls.Add(Admin_panel);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(user_password);
            Controls.Add(user_name);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.Bisque;
            ImeMode = ImeMode.On;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;

        // Add this method to the Form1 class
        private void label3_Click(object sender, EventArgs e)
        {
            // Add any desired functionality here, or leave it empty if no action is needed
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw curved background for label4 ("Login")
            //DrawRoundedRectangle(e.Graphics, label4.Bounds, 30, Color.Yellow);

            //// Draw curved background for label5 ("Create Account")
            //DrawRoundedRectangle(e.Graphics, label5.Bounds, 30, Color.Yellow);
        }

        // Helper method to draw a rounded rectangle
        //private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int radius, Color fillColor)
        //{
        //    using (GraphicsPath path = new GraphicsPath())
        //    {
        //        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
        //        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
        //        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
        //        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
        //        path.CloseFigure();

        //        using (SolidBrush brush = new SolidBrush(fillColor))
        //        {
        //            g.FillPath(brush, path);
        //        }
        //    }
        //}

        private void CustomizeControls()
        {
            // Set custom border color for textBox1 and textBox2
            user_password.BorderStyle = BorderStyle.None;
            //textBox2.BorderStyle = BorderStyle.None;

            // Add a panel as a border for each textbox
            AddTextBoxBorder(user_password, Color.SpringGreen, 2);
            //AddTextBoxBorder(textBox2, Color.SpringGreen, 2);

            // Fix the "Remember" checkbox text
            checkBox1.Text = "Remember";
        }

        private void AddTextBoxBorder(TextBox textBox, Color borderColor, int borderWidth)
        {
            var panel = new Panel
            {
                BackColor = borderColor,
                Location = new Point(textBox.Left - borderWidth, textBox.Top - borderWidth),
                Size = new Size(textBox.Width + borderWidth * 2, textBox.Height + borderWidth * 2),
                Parent = textBox.Parent
            };
            panel.BringToFront();
            textBox.Parent.Controls.Add(panel);
            panel.Controls.Add(textBox);
            textBox.Location = new Point(borderWidth, borderWidth);
        }
        private Label label6;
        private LinkLabel linkLabel1;
        private TextBox user_name;
        private TextBox user_password;
        private Label label4;
        private Label label5;
        private Button button1;
        private LinkLabel Admin_panel;
    }
}
