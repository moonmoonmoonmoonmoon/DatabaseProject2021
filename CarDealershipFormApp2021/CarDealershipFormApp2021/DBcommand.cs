using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarDealershipFormApp2021
{
    class DBcommand
    {
        database connection = new database();
        public void addVehicle(String color, String lot, String make, String model, String vin, String year, database db)
        {
            db.openConnection();
            addColor(color, db);
            addLot(lot, db);
            addMake(make, db);
            addModel(model, db);
            addVIN(vin, db);
            addYear(year, db);
            db.closeConnection();
        }
        public void addColor(String color, database db)
        // COMPLETED: this method adds a color data to the database: `dealershipdb`.`color`
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand("INSERT INTO `dealershipdb`.`color` (colorname) " +
                    "SELECT * FROM (select @colorname) as tmp " +
                    "WHERE NOT EXISTS (SELECT `colorname` " +
                    "FROM `dealershipdb`.`color` WHERE `colorname` = @colorname LIMIT 1);"
                , db.getConnection());

            command.Parameters.Add("@colorname", MySqlDbType.VarChar).Value = color;
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void addMake(String make, database db)
        // INCOMPLETE
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand("INSERT INTO `dealershipdb`.`make` (make) " +
                    "SELECT * FROM (SELECT @make) as tmp " +
                    "WHERE NOT EXISTS (SELECT `make` " +
                    "FROM `dealershipdb`.`make` WHERE `make` = @make LIMIT 1); "
                , db.getConnection());

            command.Parameters.Add("@make", MySqlDbType.VarChar).Value = make;
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void addModel(String model, database db)
        // INCOMPLETE
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand(""
                , db.getConnection());

            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void addVIN(String vin, database db)
        // INCOMPLETE
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand(""
                , db.getConnection());

            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void addYear(String year, database db)
        // INCOMPLETE
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand(""
                , db.getConnection());

            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void addLot(String lot, database db)
        // INCOMPLETE
        {
            db.openConnection();
            MySqlCommand command =
                new MySqlCommand(""
                , db.getConnection());

            command.ExecuteNonQuery();
            db.closeConnection();
        }

    }
}
