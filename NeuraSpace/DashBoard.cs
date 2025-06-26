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
        private Form1 _parentForm;
        public DashBoard(Form1 parentForm)
        {


            InitializeComponent(); ;
            _parentForm = parentForm;
            _parentForm.Hide();



        }


        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void viewUser_btn_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            new Form2(_parentForm).Show();
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
    }
}
