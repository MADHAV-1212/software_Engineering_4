using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_Engineering_4
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=10.50.118.102;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)

        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0'; // Show the password
            }
            else
            {
                textBox4.PasswordChar = '*'; // Hide the password with masking
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the Dashboard form
            forgot_password form2 = new forgot_password();
            form2.Show();

            // Show the Dashboard form


            // Optionally, hide or close the current form
            this.Hide(); // Hides the FAQ_PAGE form
                         // this.Close(); // Use this if you want to close FAQ_PAGE entirely
        }
    }
    }



