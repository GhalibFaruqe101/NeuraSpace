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
    public partial class view_sensor : Form
    {
        public view_sensor()
        {
            InitializeComponent();
        }

        private void senor_view_search_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            string username = sensor_view_username.Text;
            DataTable result = db.search_user(username);
            dataGridView1.DataSource = result;
        }
    }
}
