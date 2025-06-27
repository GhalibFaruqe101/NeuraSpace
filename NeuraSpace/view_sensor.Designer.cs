namespace NeuraSpace
{
    partial class view_sensor
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
            sensor_view_username = new TextBox();
            senor_view_search_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 447);
            dataGridView1.TabIndex = 0;
            // 
            // sensor_view_username
            // 
            sensor_view_username.Location = new Point(205, 38);
            sensor_view_username.Name = "sensor_view_username";
            sensor_view_username.PlaceholderText = "User Name";
            sensor_view_username.Size = new Size(178, 23);
            sensor_view_username.TabIndex = 1;
            // 
            // senor_view_search_btn
            // 
            senor_view_search_btn.BackColor = Color.Black;
            senor_view_search_btn.FlatAppearance.BorderSize = 0;
            senor_view_search_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            senor_view_search_btn.ForeColor = Color.White;
            senor_view_search_btn.Location = new Point(399, 25);
            senor_view_search_btn.Name = "senor_view_search_btn";
            senor_view_search_btn.Size = new Size(152, 46);
            senor_view_search_btn.TabIndex = 8;
            senor_view_search_btn.Text = "Search";
            senor_view_search_btn.UseVisualStyleBackColor = false;
            senor_view_search_btn.Click += senor_view_search_btn_Click;
            // 
            // view_sensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 602);
            Controls.Add(senor_view_search_btn);
            Controls.Add(sensor_view_username);
            Controls.Add(dataGridView1);
            Name = "view_sensor";
            Text = "view_sensor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox sensor_view_username;
        private Button senor_view_search_btn;
    }
}