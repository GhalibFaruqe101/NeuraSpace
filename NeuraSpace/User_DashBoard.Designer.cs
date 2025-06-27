namespace NeuraSpace
{
    partial class User_DashBoard
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            user_sensor_btn = new Button();
            reccommend_user_btn = new Button();
            user_logs_btn = new Button();
            panel6 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            logsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            logsToolStripMenuItem1 = new ToolStripMenuItem();
            recommandationToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 126);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(0, 192, 192);
            dateTimePicker1.CalendarTitleForeColor = Color.Teal;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            dateTimePicker1.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(1034, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 32);
            dateTimePicker1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 70);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(522, 26);
            label1.Name = "label1";
            label1.Size = new Size(291, 64);
            label1.TabIndex = 1;
            label1.Text = "NueraSpace";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(3, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 718);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 392);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(user_sensor_btn);
            panel4.Controls.Add(reccommend_user_btn);
            panel4.Controls.Add(user_logs_btn);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(309, 714);
            panel4.Name = "panel4";
            panel4.Size = new Size(689, 126);
            panel4.TabIndex = 2;
            // 
            // user_sensor_btn
            // 
            user_sensor_btn.BackColor = Color.Black;
            user_sensor_btn.FlatAppearance.BorderSize = 0;
            user_sensor_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_sensor_btn.ForeColor = Color.White;
            user_sensor_btn.Location = new Point(516, 42);
            user_sensor_btn.Name = "user_sensor_btn";
            user_sensor_btn.Size = new Size(108, 46);
            user_sensor_btn.TabIndex = 7;
            user_sensor_btn.Text = "Sensors";
            user_sensor_btn.UseVisualStyleBackColor = false;
            user_sensor_btn.Click += user_sensor_btn_Click;
            // 
            // reccommend_user_btn
            // 
            reccommend_user_btn.BackColor = Color.Black;
            reccommend_user_btn.FlatAppearance.BorderSize = 0;
            reccommend_user_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reccommend_user_btn.ForeColor = Color.White;
            reccommend_user_btn.Location = new Point(263, 42);
            reccommend_user_btn.Name = "reccommend_user_btn";
            reccommend_user_btn.Size = new Size(159, 46);
            reccommend_user_btn.TabIndex = 6;
            reccommend_user_btn.Text = "Recommend";
            reccommend_user_btn.UseVisualStyleBackColor = false;
            reccommend_user_btn.Click += reccommend_user_btn_Click;
            // 
            // user_logs_btn
            // 
            user_logs_btn.BackColor = Color.Black;
            user_logs_btn.FlatAppearance.BorderSize = 0;
            user_logs_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_logs_btn.ForeColor = Color.White;
            user_logs_btn.Location = new Point(63, 42);
            user_logs_btn.Name = "user_logs_btn";
            user_logs_btn.Size = new Size(108, 46);
            user_logs_btn.TabIndex = 5;
            user_logs_btn.Text = "Logs";
            user_logs_btn.UseVisualStyleBackColor = false;
            user_logs_btn.Click += user_logs_btn_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(3, 120);
            panel6.Name = "panel6";
            panel6.Size = new Size(116, 392);
            panel6.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { logsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(100, 26);
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(99, 22);
            logsToolStripMenuItem.Text = "Logs";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { logsToolStripMenuItem1, recommandationToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(167, 48);
            // 
            // logsToolStripMenuItem1
            // 
            logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            logsToolStripMenuItem1.Size = new Size(166, 22);
            logsToolStripMenuItem1.Text = "logs";
            // 
            // recommandationToolStripMenuItem
            // 
            recommandationToolStripMenuItem.Name = "recommandationToolStripMenuItem";
            recommandationToolStripMenuItem.Size = new Size(166, 22);
            recommandationToolStripMenuItem.Text = "recommandation";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 447);
            dataGridView1.TabIndex = 3;
            // 
            // User_DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 842);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonFace;
            Name = "User_DashBoard";
            Text = "User_DashBoard";
            Load += User_DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem logsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem logsToolStripMenuItem1;
        private ToolStripMenuItem recommandationToolStripMenuItem;
        private Button user_sensor_btn;
        private Button reccommend_user_btn;
        private Button user_logs_btn;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}