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

            users = dataBase.GetAllUsers();
            UsersListBox.DataSource = users;
            UsersListBox.DisplayMember = "FullInfo";
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
