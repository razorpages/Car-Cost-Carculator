using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace Car_Cost_Calculator
{
    public class CarCostRepository
    {
        //All Dapper Code will be entered here.
        public User user;

        /// <summary>
        /// Makes connection to the database
        /// </summary>
        /// <returns></returns>
        private IDbConnection Connect()
        {
            string Connectionstring = "Server=localhost;Database=carcostdatabase;User Id=root;Password=Tarantino.2;";
            return new MySqlConnection(Connectionstring);
        }


        //User Functions (Register and Login)
        /// <summary>
        /// Adds account to the database
        /// </summary>
        /// <param name="user">Gets the input from the user</param>
        /// <returns>true</returns>
        public bool Register(User user) 
        {
            using var connection = Connect();
            int numRowEffected = connection.Execute($@"INSERT INTO users(mail, full_name, password) VALUES(@mail, @full_name, @password);
            SELECT * FROM users;", user);
            return numRowEffected == 1;
        }

        public List<User> GetAccounts()
        {
            using var connection = Connect();
            var account = connection.Query<User>("SELECT * FROM users");
            return account.ToList();
        }

        /// <summary>
        /// Allows users to log in to their accounts
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> Login(User user) 
        {
            using var connection = Connect();
            var Login = connection.Query<User>($@"SELECT mail FROM users WHERE mail = @mail AND password = @password;");
            return Login.ToList();
        }

        //CREATE
        /// <summary>
        /// Query To add Vehicle to the Database
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public Vehicle VehicleAdd(Vehicle vehicle)
        {
            using var connection = Connect();
            connection.Query<Vehicle>(
            $@"INSERT INTO Vehicle(Number_Plate, Vehicle_Kind, Account_ID, Current_KM, BuyDate, BuyCost) VALUES (@Number_Plate, @Vehicle_Kind, @Account_ID, @Current_KM, @BuyDate, @BuyCost);", vehicle);
            return null;
        }

        /// <summary>
        /// Query To Add Costs to the Database
        /// </summary>
        /// <param name="costs"></param>
        /// <returns></returns>
        public Costs CostsAdd(Costs costs)
        {
            using var connection = Connect();
            connection.Query<Costs>(
            $@"INSERT INTO costs(Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost) VALUES (@Cost_Name, @Cost_Amount, @Cost_Date, @Vehicle_Cost);", costs);
            return null;
        }

        //READ
        /// <summary>
        /// Gets vehicles by Users
        /// </summary>
        /// <param name="inputID">Unique Account ID</param>
        /// <returns>List of All Vehicles from the designated user</returns>
        public List<Vehicle> GetVehiclesByID(string inputID) 
        {
            using var connection = Connect();
            var Items = connection.Query<Vehicle>($@"SELECT * FROM Vehicle WHERE Account_ID = @inputid", new { inputid = inputID });
            return Items.ToList();
        }

        public List<Vehicle> GetAllVehicles()
        {
            using var connection = Connect();
            var Items = connection.Query<Vehicle>($@"SELECT * FROM Vehicle");
            return Items.ToList();
        }


        /// <summary>
        /// Gets costs by Users
        /// </summary>
        /// <param name="UserID">Unique Account ID</param>
        /// <returns>List of All Costs from the selected vehicle</returns>
        public List<Vehicle> GetCostsByID(string UserID)
        {
            using var connection = Connect();
            var Items = connection.Query<Vehicle>($@"SELECT * FROM Costs WHERE Vehicle_Cost = @Vehicle_Cost", new { Vehicle_Cost = UserID });
            return Items.ToList();
        }
        

        //UPDATE

        /// <summary>
        /// Update Selected Costs
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public Costs UpdateCosts(Costs cost)
        {
            using var connection = Connect();
            var ItemUpdate = connection.QuerySingleOrDefault<Costs>(
                $@"UPDATE costs SET Cost_ID = @Cost_ID, Cost_Name = @Cost_Name, Cost_Amount = @Cost_Amount, Cost_Date = @Cost_Date, Vehicle_Cost = Vehicle_Cost = @Vehicle_Cost WHERE Cost_ID = @Cost_ID", cost);
            return ItemUpdate;
        }

        /// <summary>
        /// Updates Vehicle Information
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            using var connection = Connect();
            var ItemUpdate = connection.QuerySingleOrDefault<Vehicle>(
                $@"UPDATE Vehicle SET Number_Plate = @Number_Plate, Vehicle_Kind = @Vehicle_Kind, Account_ID = @Account_ID, Current_KM = @Current_KM, BuyDate = @BuyDate, BuyCost = @BuyCost", vehicle);
            return ItemUpdate;
        }

        //DELETE

        /// <summary>
        /// Deletes Vehicle from the database
        /// </summary>
        /// <param name="NumberPlate"></param>
        /// <returns></returns>
        public bool DeleteVehicle(string NumberPlate)
        {
            using var connection = Connect();
            int numRowsEffected = connection.Execute(
                "DELETE FROM Vehicle WHERE Number_Plate = @Number_Plate",
                new { Number_Plate = NumberPlate });

            return numRowsEffected == 1;
        }

        /// <summary>
        /// Deletes 
        /// </summary>
        /// <param name="Cost_ID"></param>
        /// <returns></returns>
        public bool DeleteCosts(int Cost_ID)
        {
            using var connection = Connect();
            int numRowsEffected = connection.Execute(
                "DELETE FROM costs WHERE Cost_ID = @CostID",
                new { CostID = Cost_ID });

            return numRowsEffected == 1;
        }



    }
}
