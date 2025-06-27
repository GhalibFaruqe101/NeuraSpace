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
    public partial class Input_Admin : Form
    {
        public Input_Admin()
        {
            InitializeComponent();
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            database_connection db = new database_connection();
            string username = admin_input_username.Text;
            DialogResult result = MessageBox.Show("Confirm to proceed", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                DataTable removed = db.remove_user(username);

            }



        }

        private void admin_input_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
