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
        /// <summary>
        /// Makes connection to the database
        /// </summary>
        /// <returns></returns>
        private IDbConnection Connect()
        {
            string Connectionstring = "Server=localhost;Database=carcostdatabase;User Id=root;Password=;";
            return new MySqlConnection(Connectionstring);
        }

        public Costs CostsAdd(Costs costs)
        {
            using var connection = Connect();
            Costs addCost = connection.QueryFirstOrDefault<Costs>(
            $@"INSERT INTO costs(
            Cost_Name, Cost_Amount, Cost_Date)
            VALUES (@Cost_Name, @Cost_Amount, @Cost_Date);"
            , new
            {
                Cost_Name = costs.Cost_Name,
                Cost_Amount = costs.Cost_Amount,
                Cost_Date = costs.Cost_Date,
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
    }
}
