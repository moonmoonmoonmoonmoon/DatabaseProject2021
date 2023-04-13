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
using MySql.Data.MySqlClient;

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

            database db = new database();

            String username = emailBox.Text;
            String password = passwordBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = 
                new MySqlCommand("SELECT email " +
                "FROM `dealershipdb`.`salesmanuid` " +
                "WHERE email = @email and password = @password", db.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if the user exist or not
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User Found");
                this.Close();
                th = new Thread(newFormThread); // opens new salesGUI form
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            } // end of if - Successful Login
            else
            {
                MessageBox.Show("No User Found");
            } // end of else - No Login

        } // submitButton_Click end

        private void newFormThread(object obj)
        {
            // Running the salesGUI form
            Application.Run(new salesGUI());
        } // end of newForm - Threaded

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserForm addUser = new addUserForm();
            addUser.ShowDialog();
        }
    }
}
