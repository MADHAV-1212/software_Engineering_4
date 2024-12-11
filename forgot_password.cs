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
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
                // Create an instance of Form1
                Form1 form1 = new Form1();

                // Show Form1
                form1.Show();

                // Optionally, hide or close the current form
                this.Hide(); // Hides the current dashboard form
                             // this.Close(); // Use this if you want to close the dashboard form completely
            
        }
    }
}
