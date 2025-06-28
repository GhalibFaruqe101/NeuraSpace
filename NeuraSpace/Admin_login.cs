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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private DashBoard DashBoard_Instance;
        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            string username = admin_user_name.Text;
            string password = admin_user_password.Text;
            bool verified = Program.dbConnect.admin_login(username, password);
            if (verified)
            {
                //MessageBox.Show("Login successful!");
                if (DashBoard_Instance == null || DashBoard_Instance.IsDisposed)
                {
                    DashBoard_Instance = new DashBoard();



                }
                DashBoard_Instance.Show();

                this.Hide();

            }
            else if (!verified)
            {
                MessageBox.Show("Login failed. Incorrect username or password.");
            }

        }
        private Form1 Form1_Instance;
        private void Admin_login_back_btn_Click(object sender, EventArgs e)
        {
            Form1_Instance = new Form1();
            Form1_Instance.Show();
            this.Hide();
        }
    }
}
