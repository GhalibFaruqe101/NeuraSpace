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
            admin_input_email = new TextBox();
            admin_input_username = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            admin_confirm_btn = new Button();
            admin_delete_input.SuspendLayout();
            SuspendLayout();
            // 
            // admin_delete_input
            // 
            admin_delete_input.Controls.Add(admin_input_email);
            admin_delete_input.Controls.Add(admin_input_username);
            admin_delete_input.Location = new Point(0, 3);
            admin_delete_input.Name = "admin_delete_input";
            admin_delete_input.RightToLeft = RightToLeft.No;
            admin_delete_input.Size = new Size(803, 100);
            admin_delete_input.TabIndex = 0;
            // 
            // admin_input_email
            // 
            admin_input_email.Location = new Point(312, 55);
            admin_input_email.Name = "admin_input_email";
            admin_input_email.PlaceholderText = "E-mail";
            admin_input_email.Size = new Size(178, 23);
            admin_input_email.TabIndex = 1;
            // 
            // admin_input_username
            // 
            admin_input_username.Location = new Point(23, 55);
            admin_input_username.Name = "admin_input_username";
            admin_input_username.PlaceholderText = "User Name";
            admin_input_username.Size = new Size(178, 23);
            admin_input_username.TabIndex = 0;
            admin_input_username.TextChanged += admin_input_username_TextChanged;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 100);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(803, 100);
            panel4.TabIndex = 1;
            // 
            // admin_confirm_btn
            // 
            admin_confirm_btn.BackColor = Color.Black;
            admin_confirm_btn.FlatAppearance.BorderSize = 0;
            admin_confirm_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_confirm_btn.ForeColor = Color.White;
            admin_confirm_btn.Location = new Point(664, 593);
            admin_confirm_btn.Name = "admin_confirm_btn";
            admin_confirm_btn.Size = new Size(108, 46);
            admin_confirm_btn.TabIndex = 6;
            admin_confirm_btn.Text = "Confirm";
            admin_confirm_btn.UseVisualStyleBackColor = false;
            admin_confirm_btn.Click += modify_btn_Click;
            // 
            // Input_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 651);
            Controls.Add(admin_confirm_btn);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(admin_delete_input);
            Name = "Input_Admin";
            admin_delete_input.ResumeLayout(false);
            admin_delete_input.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel admin_delete_input;
        private Label label1;
        private TextBox admin_input_username;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox admin_input_email;
        private Button admin_confirm_btn;
    }
}