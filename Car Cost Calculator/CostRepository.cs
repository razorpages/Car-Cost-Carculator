using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Cost_Calculator
{
    public class CostRepository
    {
        public object Number { get; private set; }

        /// <summary>
        /// Makes connection to the database
        /// </summary>
        /// <returns></returns>
        private IDbConnection Connect()
        {
            string Connectionstring = "Server=localhost;Database=carcostdatabase;User Id=root;Password=12345678";
            return new MySqlConnection(Connectionstring);
        }

        public Costs CostsAdd(Costs costs)
        {
            using var connection = Connect();
            Costs addCost = connection.QueryFirstOrDefault<Costs>(
            $@"INSERT INTO costs(
            Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost)
            VALUES (@Cost_Name, @Cost_Amount, @Cost_Date, @Vehicle_Cost);"
            , new
            {
                Cost_Name = costs.Cost_Name,
                Cost_Amount = costs.Cost_Amount,
                Cost_Date = costs.Cost_Date,
               Vehicle_Cost = costs.Vehicle_Cost
            });

            return addCost;
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


        /// <summary>
        /// Update Selected Costs
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public Costs UpdateCosts(Costs cost)
        {
            using var connection = Connect();
            var ItemUpdate = connection.QuerySingleOrDefault<Costs>(
                $@"UPDATE costs 
                SET Cost_ID = @Cost_ID, Cost_Name = @Cost_Name, Cost_Amount = @Cost_Amount, Cost_Date = @Cost_Date, Vehicle_Cost = Vehicle_Cost = @Vehicle_Cost
                WHERE Cost_ID = @Cost_ID", cost);
            return ItemUpdate;
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

        //Tank Costs
        public Tank TankCostAdd(Tank Tankcosts)
        {
            using var connection = Connect();
            var addCost = connection.QueryFirstOrDefault<Tank>(
            $@"INSERT INTO tank(
            Current_KM, Tank_Cost, Tank_Date, Vehicle_KM)
            VALUES (@Current_KM, @Tank_Cost, @Tank_Date, @Vehicle_KM);"
            , new
            {
                Current_KM = Tankcosts.Current_KM,
                Tank_Cost = Tankcosts.Tank_Cost,
                Tank_Date = Tankcosts.Tank_Date,
                Vehicle_KM = Tankcosts.Vehicle_KM
            });

           return addCost;
        }

        public List<Costs> GetCosts()
        {
            using var connection = Connect();
            var Costs = connection.Query<Costs>
                ($@"SELECT Vehicle_Kind, Number_Plate, BuyCost, tank.Tank_Cost , SUM(costs.Cost_Amount) AS MiscCosts, tank.Tank_Cost + SUM(costs.Cost_Amount) AS Total
                    FROM Vehicle
                    INNER JOIN Costs ON Vehicle.Number_Plate = Costs.Vehicle_Cost
                    INNER JOIN tank ON Vehicle.Number_Plate = tank.Vehicle_KM
                ");
            return Costs.ToList();
        }

        public List<Costs> GetAllInfo()
        {
            using var connection = Connect();
            var Costs = connection.Query<Costs>
                ($@"SELECT Vehicle_Kind, Number_Plate, BuyCost, tank.Tank_Cost , SUM(costs.Cost_Amount) AS MiscCosts, tank.Tank_Cost + SUM(costs.Cost_Amount) AS Total
                    FROM Vehicle
                    INNER JOIN Costs ON Vehicle.Number_Plate = Costs.Vehicle_Cost
                    INNER JOIN tank ON Vehicle.Number_Plate = tank.Vehicle_KM
                ");
            return Costs.ToList();
        }
    }
}
