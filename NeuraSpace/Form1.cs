namespace NeuraSpace
{

    public partial class Form1 : Form
    {
        private Form2 form2Instance; // Declare an instance of Form2

        public Form1()
        {
            InitializeComponent();
            //form2Instance = new Form2(this);
            //form2Instance.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    form2Instance.Show(); // Use the instance to call Show()
        //}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
                {
                form2Instance = new Form2(this); 
            }
            form2Instance.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string username = user_name.Text; 
            string password = user_password.Text; 
            bool verified = Program.dbConnect.validation(username, password);
            if (verified)
            {
                MessageBox.Show("Login successful!");

            }
            else
            {
                               MessageBox.Show("Login failed. Incorrect username or password.");
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
