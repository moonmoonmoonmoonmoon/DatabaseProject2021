using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipFormApp2021
{
    public partial class customerValidateForm : Form
    {
        public customerValidateForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // NOTE: this button is for the Validation Form
            // submit-button function:
            // this will send all of the new customer information to the database

            // *** check email
            if (emailBox.Text == "")
            {
                MessageBox.Show("Email Needed!");
            } // end of if-statement: email box must be filled in

            if (passwordBox.Text == "")
            {
                MessageBox.Show("Password Invalid!");
            } // end of if-statement: email box must be filled in

            else // *** send info to database and close the form
            {
                // *** SHOW ASTERISKS FOR: credit card number and CVS number
                // *** FILL IN FULL NAME and PHONE NUMBER (if there's a phone number for the customer)
                this.Close();
            } // end of else
        }

        private void customerValidateForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
