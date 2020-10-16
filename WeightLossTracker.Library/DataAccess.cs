using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WeightLossTracker.Library
{
    public class DataAccess
    {
        public List<User> GetAllUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValidation("WeightLossDB")))
            {
                var usersQuery = connection.Query<User>("select * from Users");
                var usersList = usersQuery.ToList();
                return usersList;
            }
        }
    }
}
