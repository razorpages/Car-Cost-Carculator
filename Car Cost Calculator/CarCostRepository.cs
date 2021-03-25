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

        /// <summary>
        /// Makes connection to the database
        /// </summary>
        /// <returns></returns>
        private IDbConnection Connect()
        {
            string Connectionstring = "Server=localhost;Database=happybridesdb;User Id=root;Password=x;";
            return new MySqlConnection(Connectionstring);
        }


        //User Functions (Register and Login)
        /// <summary>
        /// Adds account to the database
        /// </summary>
        /// <param name="user">Gets the input from the user</param>
        /// <returns>true</returns>
        private bool Register(User user) 
        {
            using var connection = Connect();
            int numRowEffected = connection.Execute($@"INSERT INTO users(mail, full_name, password) VALUES(@mail, @full_name, @password);", user);
            return numRowEffected == 1;
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

        //Create
        public Vehicle VehicleAdd(Vehicle vehicle)
        {
            using var connection = Connect();
            connection.Query<Vehicle>(
            $@"INSERT INTO Vehicle(Number_Plate, Vehicle_Kind, Account_ID, Current_KM, BuyDate, BuyCost) VALUES (@Number_Plate, @Vehicle_Kind, @Account_ID, @Current_KM, @BuyDate, @BuyCost);", vehicle);
            return null;
        }

        public Costs CostsAdd(Costs costs)
        {
            using var connection = Connect();
            connection.Query<Costs>(
            $@"INSERT INTO costs(Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost) VALUES (@Cost_Name, @Cost_Amount, @Cost_Date, @Vehicle_Cost);", costs);
            return null;
        }





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


    }
}
