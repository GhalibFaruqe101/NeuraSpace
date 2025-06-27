namespace NeuraSpace
{
    partial class view_logs
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
            dataGridView1 = new DataGridView();
            view_logs_search_btn = new Button();
            view_logs_username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 447);
            dataGridView1.TabIndex = 1;
            // 
            // view_logs_search_btn
            // 
            view_logs_search_btn.BackColor = Color.Black;
            view_logs_search_btn.FlatAppearance.BorderSize = 0;
            view_logs_search_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view_logs_search_btn.ForeColor = Color.White;
            view_logs_search_btn.Location = new Point(398, 39);
            view_logs_search_btn.Name = "view_logs_search_btn";
            view_logs_search_btn.Size = new Size(152, 46);
            view_logs_search_btn.TabIndex = 11;
            view_logs_search_btn.Text = "Search";
            view_logs_search_btn.UseVisualStyleBackColor = false;
            view_logs_search_btn.Click += view_logs_btn_Click;
            // 
            // view_logs_username
            // 
            view_logs_username.Location = new Point(204, 52);
            view_logs_username.Name = "view_logs_username";
            view_logs_username.PlaceholderText = "User Name";
            view_logs_username.Size = new Size(178, 23);
            view_logs_username.TabIndex = 10;
            view_logs_username.TextChanged += view_logs_username_TextChanged;
            // 
            // view_logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 612);
            Controls.Add(view_logs_search_btn);
            Controls.Add(view_logs_username);
            Controls.Add(dataGridView1);
            Name = "view_logs";
            Text = "view_logs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button view_logs_search_btn;
        private TextBox view_logs_username;
    }
}