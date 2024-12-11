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
    public partial class ACCOUNT : Form
    {
        public ACCOUNT()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            dashboard form44 = new dashboard();
            form44.Show();

            // Show the Dashboard form


            // Optionally, hide or close the current form
            this.Hide(); // Hides the FAQ_PAGE form
                         // this.Close(); // Use this if you want to close FAQ_PAGE entirely
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of Form1
                dashboard form1 = new dashboard();

                // Show Form1
                form1.Show();

                // Optionally, hide or close the current form
                this.Hide(); // Hides the current dashboard form
                             // this.Close(); // Use this if you want to close the dashboard form completely
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

