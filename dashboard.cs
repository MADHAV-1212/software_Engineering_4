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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            FAQ_PAGE form55 = new FAQ_PAGE();
            form55.Show();

            // Show the Dashboard form


            // Optionally, hide or close the current form
            this.Hide(); // Hides the FAQ_PAGE form
                         // this.Close(); // Use this if you want to close FAQ_PAGE entirely
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            ACCOUNT form33 = new ACCOUNT();
            form33.Show();

            // Show the Dashboard form


            // Optionally, hide or close the current form
            this.Hide(); // Hides the FAQ_PAGE form
                         // this.Close(); // Use this if you want to close FAQ_PAGE entirely
        }
    }
    }

