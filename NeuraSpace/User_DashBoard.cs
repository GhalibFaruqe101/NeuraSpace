using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NeuraSpace
{
    public partial class User_DashBoard : Form
    {
        private readonly string _username;
        public User_DashBoard(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void User_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void user_logs_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();

            DataTable result = db.show_user_logs(_username);
            dataGridView1.DataSource = result;


        }

        private void user_sensor_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            DataTable result = db.show_user_sensors(_username);
            dataGridView1.DataSource = result;

        }

        private void reccommend_user_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            DataTable result = db.show_user_recommandation(_username);
            dataGridView1.DataSource = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form1 Form1_Instance;
        private void user_DashBoard_back_btn_Click(object sender, EventArgs e)
        {
            Form1_Instance = new Form1();
            Form1_Instance.Show();
            this.Hide();
        }
    }
}
