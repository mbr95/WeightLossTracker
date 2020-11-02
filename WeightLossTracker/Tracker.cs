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

            int userId = UpdateSelectedUserIndex();

            if (_dataBase.DateExists(date, userId))
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

            int userId = UpdateSelectedUserIndex();

            _dataBase.DeleteWeight(date, userId);
            UpdateWeightChart();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            int userId = UpdateSelectedUserIndex();

            _dataBase.DeleteUser(userId);
            UpdateUsersBox();
        }

        private void UpdateUsersBox()
        {
            users = _dataBase.GetAllUsers();
            UsersListBox.DataSource = users;
            UsersListBox.DisplayMember = "FullInfo";
        }



        private int UpdateSelectedUserIndex()
        {
            User selectedUser = (User)UsersListBox.SelectedItem;
            int userId = selectedUser.Id;

            return userId;
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeightChart();
        }

        private void UpdateWeightChart()
        {
            string seriesName = "Weight";
            int userId = UpdateSelectedUserIndex();
            List<Weight> weights = _dataBase.GetAllWeights(userId);

            int[] minMaxAxisYValues = GetMinMaxAxisYValues(weights);
            DateTime[] minMaxAxisXValues = GetMinMaxAxisXValues(weights);

            UpdateChartSeries(seriesName);
            UpdateAxises(minMaxAxisYValues, minMaxAxisXValues);
            AddPointsToSeries(weights, seriesName);
        }

        private void UpdateChartSeries(string seriesName)
        {
            WeightChart.Series.Clear();
            WeightChart.Series.Add(seriesName);
            WeightChart.Series[seriesName].ChartType = SeriesChartType.Point;
            WeightChart.Series[0].XValueType = ChartValueType.Date;
        }

        private int[] GetMinMaxAxisYValues(List<Weight> weights)
        {
            List<Weight> weightsOrderedByValue = weights.OrderBy(e => e.Value).ToList();

            int minWeight = (int)weightsOrderedByValue.First().Value - 1;
            int maxWeight = (int)weightsOrderedByValue.Last().Value + 1;
            int[] minMaxWeights = { minWeight, maxWeight };

            return minMaxWeights;
        }

        private DateTime[] GetMinMaxAxisXValues(List<Weight> weights)
        {
            List<Weight> weightsOrderedByDate = weights.OrderBy(e => e.Date).ToList();

            DateTime minDate = weightsOrderedByDate.First().Date.AddDays(-2);
            DateTime maxDate = weightsOrderedByDate.Last().Date.AddDays(2);
            DateTime[] mixMaxDates = { minDate, maxDate };

            return mixMaxDates;
        }

        private void UpdateAxises(int[] minMaxAxisYValues, DateTime[] minMaxAxisXValues)
        {
            WeightChart.ChartAreas[0].AxisY.Minimum = minMaxAxisYValues[0];
            WeightChart.ChartAreas[0].AxisY.Maximum = minMaxAxisYValues[1];
            WeightChart.ChartAreas[0].AxisX.Minimum = minMaxAxisXValues[0].ToOADate();
            WeightChart.ChartAreas[0].AxisX.Maximum = minMaxAxisXValues[1].ToOADate();
        }

        private void AddPointsToSeries(List<Weight> weights, string seriesName)
        {
            foreach (Weight weight in weights)
            {
                WeightChart.Series[seriesName].Points.AddXY(weight.Date, weight.Value);
            }
        }

    }
}
