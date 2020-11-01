using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLossTracker.Library
{
    public interface IDataAccess
    {
        List<User> GetAllUsers();
        List<Weight> GetAllWeights(int userId);
        bool DateExists(DateTime date, int userId);
        void AddUser(string firstName, string lastName);
        void AddWeight(float value, DateTime date, int userId);
        void UpdateWeight(float value, DateTime date, int userId);
        void DeleteUser(int id);
        void DeleteWeight(DateTime date, int userId);
    }
}
