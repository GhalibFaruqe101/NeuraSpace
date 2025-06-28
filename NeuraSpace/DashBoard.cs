using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuraSpace
{
    public partial class DashBoard : Form
    {
        //private Form1 _parentForm;
        //public DashBoard(DashBoard_Instance)
        public DashBoard()
        {


            InitializeComponent();






        }


        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void viewUser_btn_Click(object sender, EventArgs e)
        {
            //int view_user = Program.dbConnect.view_user_info().Rows.Count;
            //if (view_user > 0)
            //{
            //    DataTable dt = Program.dbConnect.view_user_info();
            //    dataGridView1.DataSource = dt;

            //    dataGridView1.Refresh();

            //}
            //else
            //{
            //    MessageBox.Show("No user found in the database.");

            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Input_Admin Input_Admin_Instance;
        private void add_btn_Click(object sender, EventArgs e)
        {

            Input_Admin_Instance = new Input_Admin();
            Input_Admin_Instance.Show();

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            string username = search_box.Text;
            DataTable result = db.search_user(username);
            dataGridView1.DataSource = result;
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }
        private Input_Admin Input_Admin_Insatance;

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Input_Admin_Insatance = new Input_Admin();
            Input_Admin_Insatance.Show();
        }
        private view_sensor view_sensor_Instance;
        private void sensor_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            view_sensor_Instance = new view_sensor();
            view_sensor_Instance.Show();

        }

        private view_logs view_logs_Instance;

        private void logs_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();

            view_logs_Instance = new view_logs();
            view_logs_Instance.Show();
        }
        private Admin_login Admin_login_Instance;
        private void DashBoard_back_btn_Click(object sender, EventArgs e)
        {
            Admin_login_Instance = new Admin_login();
            Admin_login_Instance.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int view_user = Program.dbConnect.view_user_info().Rows.Count;
            if (view_user > 0)
            {
                DataTable dt = Program.dbConnect.view_user_info();
                dataGridView1.DataSource = dt;

                dataGridView1.Refresh();

            }
            else
            {
                MessageBox.Show("No user found in the database.");

            }
        }
    }
}
