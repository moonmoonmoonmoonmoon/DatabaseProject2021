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
    public partial class salesGUI : Form
    {
        public salesGUI()
        {
            InitializeComponent();
            fillBoxes();
        }

        private void refeshInventory_Click(object sender, EventArgs e)
        {
            // Check the Inventory or Delete from Inventory
            database DB4 = new database();
            DB4.openConnection();
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM `dealershipdb`.`carinfo`", DB4.getConnection());
            DataTable table = new DataTable();
            dAdapter.Fill(table);

            // fill the table directly
            dataGrid.DataSource = table;
            DB4.closeConnection();
            fillBoxes();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {

            database db = new database();
            String color = colorcomboBox.Text,
                make = makeComboBox.Text;
            DBcommand cmd = new DBcommand();

            cmd.addColor(color, db);
            cmd.addMake(make, db);

            MySqlCommand command = new MySqlCommand(
             "insert into `dealershipdb`.`carinfo` (`makeid`,`colorid`,`lotid`, `model`,`year`,`vin`) " +
             "select `makeid`,`colorid`,`lotid`, @model, @year, @vin " +
             "from `dealershipdb`.`make`, `dealershipdb`.`color`, `dealershipdb`.`lot`" +
             "WHERE `make` = @make and `colorname` = @colorname and `lotname` = @lot "
             , db.getConnection());

            command.Parameters.Add("@make", MySqlDbType.VarChar).Value = makeComboBox.Text;
            command.Parameters.Add("@colorname", MySqlDbType.VarChar).Value = colorcomboBox.Text;
            command.Parameters.Add("@lot", MySqlDbType.VarChar).Value = lotcomboBox.Text;
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = modelComboBox.Text;
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = yearcomboBox.Text;
            command.Parameters.Add("@vin", MySqlDbType.VarChar).Value = vinNumtextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) // checks each command that went through
            {
                MessageBox.Show("Successfully Added");
            } // end of if - successful
            else
            {
                MessageBox.Show("Error Occured: Registration Failed");
            } // end of else - unsuccessful

            // closes database connection
            db.closeConnection();
            fillBoxes();

        }

        private void addLotButton_Click(object sender, EventArgs e)
        {
            database DB3 = new database();
            MySqlCommand command =
                new MySqlCommand(
                    "INSERT INTO `dealershipdb`.`lot` (`lotname`, `lotnum`, `lotaddress`)" +
                    "VALUES (@lotname, @lotnumber, @address)", DB3.getConnection());

            command.Parameters.Add("@lotname", MySqlDbType.VarChar).Value = lotNametextBox.Text;
            command.Parameters.Add("@lotnumber", MySqlDbType.VarChar).Value = lotNumtextBox.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = lotAddresstextBox.Text;

            DB3.openConnection();

            if (command.ExecuteNonQuery() >= 1) // checks each command that went through
            {
                MessageBox.Show("Successfully Added");
            } // end of if - successful
            else
            {
                MessageBox.Show("Error Occured: Registration Failed");
            } // end of else - unsuccessful

            // closes database connection
            DB3.closeConnection();
            fillBoxes();
        }

        private void fillBoxes()
        {

            // consider turning the large piece of code into a function instead!!!
            database DB2 = new database();
            MySqlCommand cmd = new MySqlCommand("SELECT `colorname` " +
            "FROM `dealershipdb`.`color`;", DB2.getConnection());
            MySqlDataReader myReader;
            try
            {
                colorcomboBox.Items.Clear();
                DB2.openConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    String colorname = myReader.GetString("colorname");
                    colorcomboBox.Items.Add(colorname);
                }
                DB2.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try { 
            //--------------------------------------------------------------//
            cmd = new MySqlCommand("SELECT `make` " +
                "FROM `dealershipdb`.`make`;", DB2.getConnection());

                makeComboBox.Items.Clear();
                DB2.openConnection();
                myReader = cmd.ExecuteReader();
                
                while (myReader.Read())
                {
                    String make = myReader.GetString("make");
                    makeComboBox.Items.Add(make);
                }
                DB2.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try { 
                //--------------------------------------------------------------//
                cmd = new MySqlCommand("SELECT `model` " +
                "FROM `dealershipdb`.`carinfo`;", DB2.getConnection());

                modelComboBox.Items.Clear();
                DB2.openConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    String model = myReader.GetString("model");
                    modelComboBox.Items.Add(model);
                }
                DB2.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try { 
                //--------------------------------------------------------------//
                cmd = new MySqlCommand("SELECT `lotname` " +
                "FROM `dealershipdb`.`lot`;", DB2.getConnection());

                lotcomboBox.Items.Clear();
                DB2.openConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    String lotname = myReader.GetString("lotname");
                    lotcomboBox.Items.Add(lotname);
                }
                DB2.closeConnection();
                //--------------------------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // consider turning the large piece of code into a function instead!!!
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            database db = new database();
            String color = colorcomboBox.Text;

            DBcommand colorCMD = new DBcommand();
            try
            {
                colorCMD.addColor(colorcomboBox.Text, db);
                MessageBox.Show("Added color: " + color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION ERROR: " + ex.Message);
            }
            fillBoxes();
        } // add color button
    }
}
