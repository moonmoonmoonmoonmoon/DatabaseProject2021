using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipFormApp2021
{
    public partial class salesLoginForm : Form
    {
        public salesLoginForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Thread th; // thread for newForm
            // submit-button function:
            // this will check the salesperson's credentials on the DB

            // *** check email
            if (emailBox.Text == "")
            {
                MessageBox.Show("Email Incomplete!");
            } // end of if-statement: email box must be filled in

            if (passwordBox.Text == "")
            {
                MessageBox.Show("Password Invalid!");
            } // end of if-statement: email box must be filled in

            else // *** send info to database and close the form
            {
                // *** Save Information to Database
                // *** Code Here for that
                this.Close();
                th = new Thread(newFormThread); // opens new salesGUI form
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            } // end of else

        } // submitButton_Click end

        private void newFormThread(object obj)
        {
            // Running the salesGUI form
            Application.Run(new salesGUI());
        } // end of newForm - Threaded
    }
}
