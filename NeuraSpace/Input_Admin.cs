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

                bool removed = db.remove_user(username);

            }



        }

        private void admin_input_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_input_add_Click(object sender, EventArgs e)
        {
            string username = admin_input_username.Text;
            string fullname = admin_input_fullname.Text;
            string password = admin_input_pass.Text;
            string confirm_pass = admin_input_passCom.Text;
            string email = admin_input_email.Text;
            string phone = Admin_input_phone.Text;
            if (password == confirm_pass)
            {
                int result = Program.dbConnect.register_user(fullname, username, password, email, phone);
                if (result > 0)
                {
                    MessageBox.Show("newpp user input into the system!");
                    this.Close();
                  
                }
                else
                {
                    MessageBox.Show("failed. wrong input.");

                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");


            }

        }
    }
}
