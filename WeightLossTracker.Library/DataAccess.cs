using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using Npgsql.TypeMapping;

namespace WeightLossTracker.Library
{
    public class DataAccess : IDataAccess
    {
        public List<User> GetAllUsers()
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                string getAllUsersQuery = "select * from \"User\"";

                var usersQuery = connection.Query<User>(getAllUsersQuery);
                var usersList = usersQuery.ToList();

                return usersList;
            }
        }

        public List<Weight> GetAllWeights(int userId)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                string getAllWeightsQuery = "select * from \"Weight\" where \"UserId\" = @UserId";

                var weightsQuery = connection.Query<Weight>(getAllWeightsQuery, new { UserId = userId });
                var weightsList = weightsQuery.ToList();

                return weightsList;
            }
        }

        public bool DateExists(DateTime date, int userId)
        {
            using(IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string checkIfDateExistsQuery = "select * from \"Weight\" where \"Date\" = @Date and \"UserId\" = @UserId";

                using (NpgsqlCommand command = new NpgsqlCommand(checkIfDateExistsQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("@Date", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters[0].Value = date;
                    command.Parameters.AddWithValue("@UserId", userId);

                    var dataReader = command.ExecuteReader();
                    bool dateExist = dataReader.HasRows;
                    connection.Close();

                    return dateExist;
                }

            }
        }

        public void AddUser(string firstName, string lastName)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string addUserQuery = "insert into \"User\" (\"FirstName\", \"LastName\") values (@FirstName, @LastName)";

                using (NpgsqlCommand command = new NpgsqlCommand(addUserQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    command.ExecuteReader();
                }
                connection.Close();    
            }
        }

        public void AddWeight(float value, DateTime date, int userId)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string addWeightQuery = "insert into \"Weight\" (\"Value\", \"Date\", \"UserId\") values (@Value, @Date, @UserId)";

                using (NpgsqlCommand command = new NpgsqlCommand(addWeightQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.Add(new NpgsqlParameter("@Date", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters[1].Value = date;
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public void UpdateWeight(float value, DateTime date, int userId)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string UpdateWeightQuery = "update \"Weight\" set \"Value\" = @Value where \"UserId\" = @UserId and \"Date\" = @Date";

                using (NpgsqlCommand command = new NpgsqlCommand(UpdateWeightQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.Add(new NpgsqlParameter("@Date", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters[1].Value = date;
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public void DeleteUser(int id)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string addUserQuery = "delete from \"User\" where \"Id\" = @Id";

                using (NpgsqlCommand command = new NpgsqlCommand(addUserQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public void DeleteWeight(DateTime date, int userId)
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                connection.Open();
                string UpdateWeightQuery = "delete from \"Weight\" where \"UserId\" = @UserId and \"Date\" = @Date";

                using (NpgsqlCommand command = new NpgsqlCommand(UpdateWeightQuery, (NpgsqlConnection)connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("@Date", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters[0].Value = date;
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteReader();
                }
                connection.Close();
            }
        }
    }
}
