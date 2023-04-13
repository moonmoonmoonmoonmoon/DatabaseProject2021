using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealershipFormApp2021
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // NOTE: this button is for the Validation Form
            // submit-button function:
            // this will send all of the new customer information to the database

            String email = emailBox.Text;
            String password = passwordBox.Text;
            String nameF = firstNameBox.Text;
            String nameL = lastNameBox.Text;

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
                database DB = new database();
                MySqlCommand command = 
                    new MySqlCommand(
                    "INSERT INTO `dealershipdb`.`salesmanname` (`nfirst`, `nlast`) " +
                    "VALUES (@nameF, @nameL); " +
                    "INSERT INTO `dealershipdb`.`salesmanuid` (`salesmanid`,`email`, `password`) " +
                    "SELECT `salesmanname`.`salesmanid`, @email, @password FROM `dealershipdb`.`salesmanname`" +
                    "WHERE `salesmanname`.`salesmanid` = (SELECT MAX(`salesmanid`) FROM `salesmanname`); "
                    , DB.getConnection());

                command.Parameters.Add("@nameF", MySqlDbType.VarChar).Value = firstNameBox.Text;
                command.Parameters.Add("@nameL", MySqlDbType.VarChar).Value = lastNameBox.Text;
                command.Parameters.Add("@salesID", MySqlDbType.VarChar).Value = salesIDbox.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailBox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordBox.Text;

                // opens database connection
                DB.openConnection();

                if (command.ExecuteNonQuery() == 3)
                {
                    MessageBox.Show("Successfully Registered");
                } // end of if - successful registration
                else
                {
                    MessageBox.Show("Error Occured: Registration Failed");
                } // end of else - unsuccessful registration 

                // closes database connection
                DB.closeConnection();

                this.Close();
            } // end of else
        }
    }
}
