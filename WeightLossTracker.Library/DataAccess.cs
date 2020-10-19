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

namespace WeightLossTracker.Library
{
    public class DataAccess
    {
        public List<User> GetAllUsers()
        {
            using (IDbConnection connection = new NpgsqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                string getAllQuery = "select * from \"User\"";

                var usersQuery = connection.Query<User>(getAllQuery);
                var usersList = usersQuery.ToList();

                return usersList;
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

    }
}
