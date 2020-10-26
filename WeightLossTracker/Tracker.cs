using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightLossTracker.Library;

namespace WeightLossTracker
{
    public partial class Tracker : Form
    {
        DataAccess dataBase = new DataAccess();
        List<User> users = new List<User>();

        public Tracker()
        {
            InitializeComponent();

            UpdateUsersBox();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            dataBase.AddUser(FirstNameBox.Text, LastNameBox.Text);

            UpdateUsersBox();
        }

        private void UpdateUsersBox() 
        {
            users = dataBase.GetAllUsers();
            UsersListBox.DataSource = users;
            UsersListBox.DisplayMember = "FullInfo";
        }

        private void UpdateWeightBtn_Click(object sender, EventArgs e)
        {
            float value = float.Parse(WeightValueBox.Text);

            DateTime date = dateTimePicker.Value;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            if(dataBase.DateExists(date, userId))
            {
                dataBase.UpdateWeight(value, date, userId);
            } 
            else
            {
                dataBase.AddWeight(value, date, userId);
            }

        }



    }
}
