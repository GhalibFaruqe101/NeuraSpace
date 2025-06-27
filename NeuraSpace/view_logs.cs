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
    public partial class view_logs : Form
    {
        public view_logs()
        {
            InitializeComponent();
        }

        private void view_logs_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            string username = view_logs_username.Text;
            DataTable result = db.logs_information(username);
            dataGridView1.DataSource = result;

        }

        private void view_logs_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
