namespace NeuraSpace
{
    partial class DashBoard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            DashBoard_back_btn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            sensor_btn = new Button();
            logs_btn = new Button();
            viewUser_btn = new Button();
            dataGridView1 = new DataGridView();
            add_btn = new Button();
            modify_btn = new Button();
            delete_btn = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            search_btn = new Button();
            search_box = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(DashBoard_back_btn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 3);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2025, 130);
            panel1.TabIndex = 1;
            // 
            // DashBoard_back_btn
            // 
            DashBoard_back_btn.BackColor = Color.Black;
            DashBoard_back_btn.FlatAppearance.BorderSize = 0;
            DashBoard_back_btn.ForeColor = Color.White;
            DashBoard_back_btn.Location = new Point(28, 20);
            DashBoard_back_btn.Name = "DashBoard_back_btn";
            DashBoard_back_btn.Size = new Size(65, 41);
            DashBoard_back_btn.TabIndex = 17;
            DashBoard_back_btn.Text = "Back";
            DashBoard_back_btn.UseVisualStyleBackColor = false;
            DashBoard_back_btn.Click += DashBoard_back_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(5, 135);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 130);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(sensor_btn);
            panel3.Controls.Add(logs_btn);
            panel3.Controls.Add(viewUser_btn);
            panel3.Location = new Point(0, 127);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 837);
            panel3.TabIndex = 2;
            // 
            // sensor_btn
            // 
            sensor_btn.BackColor = Color.Turquoise;
            sensor_btn.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sensor_btn.Location = new Point(-1, 414);
            sensor_btn.Margin = new Padding(5);
            sensor_btn.Name = "sensor_btn";
            sensor_btn.Size = new Size(195, 95);
            sensor_btn.TabIndex = 5;
            sensor_btn.Text = "Sensors";
            sensor_btn.UseVisualStyleBackColor = false;
            sensor_btn.Click += sensor_btn_Click;
            // 
            // logs_btn
            // 
            logs_btn.BackColor = Color.Turquoise;
            logs_btn.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logs_btn.Location = new Point(-3, 243);
            logs_btn.Margin = new Padding(5);
            logs_btn.Name = "logs_btn";
            logs_btn.Size = new Size(195, 95);
            logs_btn.TabIndex = 4;
            logs_btn.Text = "Logs";
            logs_btn.UseVisualStyleBackColor = false;
            logs_btn.Click += logs_btn_Click;
            // 
            // viewUser_btn
            // 
            viewUser_btn.BackColor = Color.Turquoise;
            viewUser_btn.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUser_btn.Location = new Point(-3, 68);
            viewUser_btn.Margin = new Padding(5);
            viewUser_btn.Name = "viewUser_btn";
            viewUser_btn.Size = new Size(195, 95);
            viewUser_btn.TabIndex = 3;
            viewUser_btn.Text = "User";
            viewUser_btn.UseVisualStyleBackColor = false;
            viewUser_btn.Click += viewUser_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.RoyalBlue;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(790, 489);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Black;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(494, 767);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(108, 46);
            add_btn.TabIndex = 4;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // modify_btn
            // 
            modify_btn.BackColor = Color.Black;
            modify_btn.FlatAppearance.BorderSize = 0;
            modify_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modify_btn.ForeColor = Color.White;
            modify_btn.Location = new Point(747, 768);
            modify_btn.Name = "modify_btn";
            modify_btn.Size = new Size(108, 46);
            modify_btn.TabIndex = 5;
            modify_btn.Text = "Modify";
            modify_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(621, 767);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(108, 46);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Black;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(939, 188);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(152, 46);
            search_btn.TabIndex = 7;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(681, 195);
            search_box.Name = "search_box";
            search_box.PlaceholderText = " search ";
            search_box.Size = new Size(252, 33);
            search_box.TabIndex = 8;
            search_box.TextChanged += search_box_TextChanged;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1246, 842);
            Controls.Add(search_box);
            Controls.Add(search_btn);
            Controls.Add(delete_btn);
            Controls.Add(modify_btn);
            Controls.Add(add_btn);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button viewUser_btn;
        private Button logs_btn;
        private Button sensor_btn;
        private DataGridView dataGridView1;
        private Button add_btn;
        private Button modify_btn;
        private Button delete_btn;
        private FileSystemWatcher fileSystemWatcher1;
        private Button search_btn;
        private TextBox search_box;
        private Button DashBoard_back_btn;
    }
}