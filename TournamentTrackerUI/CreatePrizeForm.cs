﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);
                
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This Form has invalid information. Please check the form");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placenumber = 0;
            if (int.TryParse(placeNumberValue.Text, out placenumber) == false)
            {
                output = false;
            }
            if (placenumber < 1)
            {
                output = false;
            }
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeamount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeamount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);


            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeamount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
