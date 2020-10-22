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

        private void AddWeightBtn_Click(object sender, EventArgs e)
        {
            float value = float.Parse(WeightValueBox.Text);

            DateTime date = DateTime.Now;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            dataBase.AddWeight(value, date, userId);
        }

        private void GetWeightButton_Click(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            Weight weightForDate = dataBase.GetWeightForDate(date, userId);
            List<Weight> weights = new List<Weight>();
            weights.Add(weightForDate);
            showWeightBox.DataSource = weights;
            showWeightBox.DisplayMember = "Value" + "Date";
        }
    }
}
