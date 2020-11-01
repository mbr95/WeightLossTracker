using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WeightLossTracker.Library;

namespace WeightLossTracker
{
    public partial class Tracker : Form
    {
        private IDataAccess _dataBase { get; set; }

        List<User> users = new List<User>();

        public Tracker(IDataAccess dataBase)
        {
            InitializeComponent();

            _dataBase = dataBase;

            UpdateUsersBox();
            UpdateWeightChart();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            _dataBase.AddUser(FirstNameBox.Text, LastNameBox.Text);

            UpdateUsersBox();
        }

        

        private void UpdateWeightBtn_Click(object sender, EventArgs e)
        {
            float value = float.Parse(WeightValueBox.Text);

            DateTime date = dateTimePicker.Value;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            if(_dataBase.DateExists(date, userId))
            {
                _dataBase.UpdateWeight(value, date, userId);
            } 
            else
            {
                _dataBase.AddWeight(value, date, userId);
            }

            UpdateWeightChart();
        }

        private void DeleteWeightBtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            _dataBase.DeleteWeight(date, userId);
            UpdateWeightChart();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            _dataBase.DeleteUser(userId);
            UpdateUsersBox();
        }

        private void UpdateUsersBox() 
        {
            users = _dataBase.GetAllUsers();
            UsersListBox.DataSource = users;
            UsersListBox.DisplayMember = "FullInfo";
        }

        private void UpdateWeightChart()
        {
            WeightChart.Series.Clear();
            WeightChart.Series.Add("Weight");
            WeightChart.Series["Weight"].ChartType = SeriesChartType.Point;

            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            List<Weight> weights = _dataBase.GetAllWeights(userId);
            List<Weight> weightsOrderedByValue = weights.OrderBy(e => e.Value).ToList();
            List<Weight> weightsOrderedByDate = weights.OrderBy(e => e.Date).ToList();

            int minWeight = (int)weightsOrderedByValue.First().Value - 1;
            int maxWeight = (int)weightsOrderedByValue.Last().Value + 1;
            DateTime minDate = weightsOrderedByDate.First().Date.AddDays(-2);
            DateTime maxDate = weightsOrderedByDate.Last().Date.AddDays(2);

            WeightChart.Series[0].XValueType = ChartValueType.Date;
            WeightChart.ChartAreas[0].AxisY.Minimum = minWeight;
            WeightChart.ChartAreas[0].AxisY.Maximum = maxWeight;
            WeightChart.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            WeightChart.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            foreach (Weight weight in weights)
            {
                WeightChart.Series["Weight"].Points.AddXY(weight.Date, weight.Value);
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeightChart();
        }
    }
}
