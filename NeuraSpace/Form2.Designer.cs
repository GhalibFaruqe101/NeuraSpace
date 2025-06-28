namespace NeuraSpace
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            full_name = new TextBox();
            user_name = new TextBox();
            label3 = new Label();
            user_email = new TextBox();
            label4 = new Label();
            user_phone = new TextBox();
            label5 = new Label();
            user_password = new TextBox();
            label6 = new Label();
            confirm_password = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            reg_back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 54);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 0;
            label1.Text = "Registration\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 150);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // full_name
            // 
            full_name.Cursor = Cursors.IBeam;
            full_name.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            full_name.ForeColor = SystemColors.InactiveCaptionText;
            full_name.Location = new Point(63, 190);
            full_name.Name = "full_name";
            full_name.PlaceholderText = "Enter your name";
            full_name.Size = new Size(261, 23);
            full_name.TabIndex = 2;
            // 
            // user_name
            // 
            user_name.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            user_name.ForeColor = SystemColors.InactiveCaptionText;
            user_name.Location = new Point(450, 191);
            user_name.Name = "user_name";
            user_name.PlaceholderText = "Enter your username";
            user_name.Size = new Size(261, 23);
            user_name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(450, 150);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 3;
            label3.Text = "User Name";
            // 
            // user_email
            // 
            user_email.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            user_email.ForeColor = SystemColors.InactiveCaptionText;
            user_email.Location = new Point(63, 288);
            user_email.Name = "user_email";
            user_email.PlaceholderText = "Enter your email address";
            user_email.Size = new Size(261, 23);
            user_email.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 247);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 5;
            label4.Text = "E-mail";
            // 
            // user_phone
            // 
            user_phone.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            user_phone.ForeColor = SystemColors.InactiveCaptionText;
            user_phone.Location = new Point(450, 288);
            user_phone.Name = "user_phone";
            user_phone.PlaceholderText = "Enter your Phone number";
            user_phone.Size = new Size(261, 23);
            user_phone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(446, 247);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 7;
            label5.Text = "Phone";
            // 
            // user_password
            // 
            user_password.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            user_password.ForeColor = SystemColors.InactiveCaptionText;
            user_password.Location = new Point(63, 388);
            user_password.Name = "user_password";
            user_password.PlaceholderText = "Enter your Password";
            user_password.Size = new Size(261, 23);
            user_password.TabIndex = 10;
            user_password.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(63, 338);
            label6.Name = "label6";
            label6.Size = new Size(100, 26);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // confirm_password
            // 
            confirm_password.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            confirm_password.ForeColor = SystemColors.InactiveCaptionText;
            confirm_password.Location = new Point(450, 388);
            confirm_password.Name = "confirm_password";
            confirm_password.PlaceholderText = "Confirm Password";
            confirm_password.Size = new Size(261, 23);
            confirm_password.TabIndex = 12;
            confirm_password.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(450, 338);
            label7.Name = "label7";
            label7.Size = new Size(181, 26);
            label7.TabIndex = 11;
            label7.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(212, 500);
            button1.Name = "button1";
            button1.Size = new Size(347, 61);
            button1.TabIndex = 14;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(296, 102);
            button2.Name = "button2";
            button2.Size = new Size(82, 10);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = false;
            // 
            // reg_back_btn
            // 
            reg_back_btn.BackColor = Color.Black;
            reg_back_btn.FlatAppearance.BorderSize = 0;
            reg_back_btn.ForeColor = Color.White;
            reg_back_btn.Location = new Point(12, 12);
            reg_back_btn.Name = "reg_back_btn";
            reg_back_btn.Size = new Size(54, 36);
            reg_back_btn.TabIndex = 16;
            reg_back_btn.Text = "Back";
            reg_back_btn.UseVisualStyleBackColor = false;
            reg_back_btn.Click += reg_back_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(789, 642);
            Controls.Add(reg_back_btn);
            Controls.Add(full_name);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(confirm_password);
            Controls.Add(label7);
            Controls.Add(user_password);
            Controls.Add(label6);
            Controls.Add(user_phone);
            Controls.Add(label5);
            Controls.Add(user_email);
            Controls.Add(label4);
            Controls.Add(user_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox full_name;
        private TextBox user_name;
        private Label label3;
        private TextBox user_email;
        private Label label4;
        private TextBox user_phone;
        private Label label5;
        private TextBox user_password;
        private Label label6;
        private TextBox confirm_password;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button reg_back_btn;
    }
}