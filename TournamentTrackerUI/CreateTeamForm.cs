using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availiableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availiableTeamMembers.Add(new PersonModel {FirstName = "Nikolaj",LastName = "Matzen"});
            availiableTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
            availiableTeamMembers.Add(new PersonModel { FirstName = "Mary", LastName = "Jane" });
            availiableTeamMembers.Add(new PersonModel { FirstName = "Hans", LastName = "Kruger" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Hans", LastName = "Kruger" });

        }

        private void WireUpLists()
        {
            
            selectTeamMemberDropDown.DataSource = availiableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void tournamentLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()==false)
            {
                MessageBox.Show("Form invalid");
                return;
            }

            PersonModel p = new PersonModel();

            p.FirstName = firstNameTextBox.Text;
            p.LastName = lastNameTextBox.Text;
            p.CellphoneNumber = cellPhoneValue.Text;
            p.EmailAddress = emailValue.Text;

            GlobalConfig.Connection.CreatePerson(p);
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            cellPhoneValue.Text = "";
            emailValue.Text = "";
        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length==0)
            {
                return false;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
