namespace NeuraSpace
{
    partial class Admin_login
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
            panel1 = new Panel();
            admin_login_btn = new Button();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            admin_user_password = new TextBox();
            admin_user_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Admin_login_back_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(admin_login_btn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(admin_user_password);
            panel1.Controls.Add(admin_user_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(229, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 766);
            panel1.TabIndex = 0;
            // 
            // admin_login_btn
            // 
            admin_login_btn.BackColor = Color.Black;
            admin_login_btn.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_login_btn.ForeColor = SystemColors.ControlLight;
            admin_login_btn.Location = new Point(135, 688);
            admin_login_btn.Name = "admin_login_btn";
            admin_login_btn.Size = new Size(184, 45);
            admin_login_btn.TabIndex = 23;
            admin_login_btn.Text = "Login";
            admin_login_btn.UseVisualStyleBackColor = false;
            admin_login_btn.Click += admin_login_btn_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Cyan;
            label7.Location = new Point(135, 192);
            label7.Name = "label7";
            label7.Size = new Size(165, 10);
            label7.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(135, 136);
            label6.Name = "label6";
            label6.Size = new Size(171, 64);
            label6.TabIndex = 22;
            label6.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(85, 37);
            label1.Name = "label1";
            label1.Size = new Size(291, 64);
            label1.TabIndex = 21;
            label1.Text = "NueraSpace";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.HighlightText;
            label5.Font = new Font("Segoe UI", 1F, FontStyle.Bold);
            label5.Location = new Point(104, 645);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(238, 2);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.HighlightText;
            label4.Font = new Font("Segoe UI", 1F, FontStyle.Bold);
            label4.Location = new Point(104, 526);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(238, 2);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // admin_user_password
            // 
            admin_user_password.BackColor = Color.Black;
            admin_user_password.BorderStyle = BorderStyle.None;
            admin_user_password.Cursor = Cursors.IBeam;
            admin_user_password.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_user_password.ForeColor = SystemColors.InactiveCaption;
            admin_user_password.Location = new Point(102, 613);
            admin_user_password.Name = "admin_user_password";
            admin_user_password.PlaceholderText = "Enter Password";
            admin_user_password.Size = new Size(235, 28);
            admin_user_password.TabIndex = 18;
            // 
            // admin_user_name
            // 
            admin_user_name.BackColor = Color.Black;
            admin_user_name.BorderStyle = BorderStyle.None;
            admin_user_name.Cursor = Cursors.IBeam;
            admin_user_name.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_user_name.ForeColor = SystemColors.InactiveCaption;
            admin_user_name.Location = new Point(104, 494);
            admin_user_name.Margin = new Padding(6);
            admin_user_name.Name = "admin_user_name";
            admin_user_name.PlaceholderText = "Enter Username";
            admin_user_name.Size = new Size(235, 28);
            admin_user_name.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(102, 566);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowText;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(104, 446);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 15;
            label2.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(164, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Admin_login_back_btn
            // 
            Admin_login_back_btn.BackColor = Color.Black;
            Admin_login_back_btn.FlatAppearance.BorderSize = 0;
            Admin_login_back_btn.ForeColor = Color.White;
            Admin_login_back_btn.Location = new Point(12, 12);
            Admin_login_back_btn.Name = "Admin_login_back_btn";
            Admin_login_back_btn.Size = new Size(54, 36);
            Admin_login_back_btn.TabIndex = 24;
            Admin_login_back_btn.Text = "Back";
            Admin_login_back_btn.UseVisualStyleBackColor = false;
            Admin_login_back_btn.Click += Admin_login_back_btn_Click;
            // 
            // Admin_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 861);
            Controls.Add(Admin_login_back_btn);
            Controls.Add(panel1);
            Name = "Admin_login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private TextBox admin_user_password;
        private TextBox admin_user_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Button admin_login_btn;
        private Button Admin_login_back_btn;
    }
}