using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuraSpace
{
    public partial class Form2 : Form
    {
        private Form1 _parentForm;
        public Form2(Form1 parentForm)
        {
            InitializeComponent(); ;
            _parentForm = parentForm;
            _parentForm.Hide();

            //InitializeComponent();
            //Form1.ActiveForm?.Hide(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = user_name.Text;
            string fullname = full_name.Text;
            string password = user_password.Text;
            string confirm_pass = confirm_password.Text;
            string email = user_email.Text;
            string phone = user_phone.Text;
            if (password == confirm_pass)
            {
            int result = Program.dbConnect.register_user(fullname, username, password, email, phone);
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!");
                    this.Close();
                    _parentForm.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");

                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");


            }
        }
    }
}
       
