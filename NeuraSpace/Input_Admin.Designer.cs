namespace NeuraSpace
{
    partial class Input_Admin
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
            admin_delete_input = new Panel();
            admin_input_fullname = new TextBox();
            admin_input_username = new TextBox();
            admin_input_email = new TextBox();
            panel2 = new Panel();
            Admin_input_phone = new TextBox();
            panel3 = new Panel();
            admin_input_passCom = new TextBox();
            admin_input_pass = new TextBox();
            panel4 = new Panel();
            admin_confirm_btn = new Button();
            Admin_input_add = new Button();
            admin_delete_input.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // admin_delete_input
            // 
            admin_delete_input.BackColor = Color.OrangeRed;
            admin_delete_input.Controls.Add(admin_input_fullname);
            admin_delete_input.Controls.Add(admin_input_username);
            admin_delete_input.Location = new Point(0, 3);
            admin_delete_input.Name = "admin_delete_input";
            admin_delete_input.RightToLeft = RightToLeft.No;
            admin_delete_input.Size = new Size(803, 100);
            admin_delete_input.TabIndex = 0;
            // 
            // admin_input_fullname
            // 
            admin_input_fullname.Location = new Point(118, 55);
            admin_input_fullname.Name = "admin_input_fullname";
            admin_input_fullname.PlaceholderText = "Full Name";
            admin_input_fullname.Size = new Size(178, 23);
            admin_input_fullname.TabIndex = 0;
            admin_input_fullname.TextChanged += admin_input_username_TextChanged;
            // 
            // admin_input_username
            // 
            admin_input_username.Location = new Point(396, 55);
            admin_input_username.Name = "admin_input_username";
            admin_input_username.PlaceholderText = "User Name";
            admin_input_username.Size = new Size(178, 23);
            admin_input_username.TabIndex = 2;
            admin_input_username.TextChanged += textBox2_TextChanged;
            // 
            // admin_input_email
            // 
            admin_input_email.Location = new Point(396, 35);
            admin_input_email.Name = "admin_input_email";
            admin_input_email.PlaceholderText = "E-Mail";
            admin_input_email.Size = new Size(178, 23);
            admin_input_email.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(admin_input_email);
            panel2.Controls.Add(Admin_input_phone);
            panel2.Location = new Point(0, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 100);
            panel2.TabIndex = 1;
            // 
            // Admin_input_phone
            // 
            Admin_input_phone.Location = new Point(118, 35);
            Admin_input_phone.Name = "Admin_input_phone";
            Admin_input_phone.PlaceholderText = "Phone Number";
            Admin_input_phone.Size = new Size(178, 23);
            Admin_input_phone.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Controls.Add(admin_input_passCom);
            panel3.Controls.Add(admin_input_pass);
            panel3.Location = new Point(0, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 100);
            panel3.TabIndex = 1;
            // 
            // admin_input_passCom
            // 
            admin_input_passCom.Location = new Point(396, 42);
            admin_input_passCom.Name = "admin_input_passCom";
            admin_input_passCom.PlaceholderText = "Confirm Password";
            admin_input_passCom.Size = new Size(178, 23);
            admin_input_passCom.TabIndex = 3;
            // 
            // admin_input_pass
            // 
            admin_input_pass.Location = new Point(118, 42);
            admin_input_pass.Name = "admin_input_pass";
            admin_input_pass.PlaceholderText = "Password";
            admin_input_pass.Size = new Size(178, 23);
            admin_input_pass.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.OrangeRed;
            panel4.Controls.Add(Admin_input_add);
            panel4.Controls.Add(admin_confirm_btn);
            panel4.Location = new Point(0, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(701, 100);
            panel4.TabIndex = 1;
            // 
            // admin_confirm_btn
            // 
            admin_confirm_btn.BackColor = Color.Black;
            admin_confirm_btn.FlatAppearance.BorderSize = 0;
            admin_confirm_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_confirm_btn.ForeColor = Color.White;
            admin_confirm_btn.Location = new Point(432, 24);
            admin_confirm_btn.Name = "admin_confirm_btn";
            admin_confirm_btn.Size = new Size(108, 46);
            admin_confirm_btn.TabIndex = 6;
            admin_confirm_btn.Text = "Delete";
            admin_confirm_btn.UseVisualStyleBackColor = false;
            admin_confirm_btn.Click += modify_btn_Click;
            // 
            // Admin_input_add
            // 
            Admin_input_add.BackColor = Color.Black;
            Admin_input_add.FlatAppearance.BorderSize = 0;
            Admin_input_add.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_input_add.ForeColor = Color.White;
            Admin_input_add.Location = new Point(118, 24);
            Admin_input_add.Name = "Admin_input_add";
            Admin_input_add.Size = new Size(108, 46);
            Admin_input_add.TabIndex = 7;
            Admin_input_add.Text = "Add";
            Admin_input_add.UseVisualStyleBackColor = false;
            Admin_input_add.Click += Admin_input_add_Click;
            // 
            // Input_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(697, 532);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(admin_delete_input);
            Name = "Input_Admin";
            admin_delete_input.ResumeLayout(false);
            admin_delete_input.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel admin_delete_input;
        private Label label1;
        private TextBox admin_input_fullname;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox admin_input_email;
        private Button admin_confirm_btn;
        private TextBox admin_input_username;
        private TextBox Admin_input_phone;
        private TextBox admin_input_passCom;
        private TextBox admin_input_pass;
        private Button Admin_input_add;
    }
}