using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleInterestCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(principalEntry.Text) || string.IsNullOrWhiteSpace(rateEntry.Text) || string.IsNullOrWhiteSpace(timeEntry.Text))
                {
                    DisplayAlert("Error", "Please fill in all the fields", "OK");
                }
                else
                {
                    double principal = Convert.ToDouble(principalEntry.Text);
                    double rate = Convert.ToDouble(rateEntry.Text);
                    double time = Convert.ToDouble(timeEntry.Text);

                    double simpleInterest = (principal * rate * time) / 100;

                    resultLabel.Text = $"Simple Interest: {simpleInterest:C}";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please fill in the field values in numbers", "OK");
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            principalEntry.Text = string.Empty;
            rateEntry.Text = string.Empty;
            timeEntry.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }
    }
}
