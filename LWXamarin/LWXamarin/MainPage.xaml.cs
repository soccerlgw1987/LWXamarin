using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LWXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            getHouseholdsBtn.Clicked += NavigateHouseholdsBtn_OnClicked;
            getAccountsBtn.Clicked += NavigateAccountsBtn_OnClicked;
            getAccountDetailsBtn.Clicked += NavigateAccountDetailsBtn_OnClicked;
            getTransactionsBtn.Clicked += NavigateTransactionsBtn_OnClicked;
        }

        private async void NavigateHouseholdsBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HouseholdsPage());
        }
        private async void NavigateAccountsBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
        }
        private async void NavigateAccountDetailsBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountDetailsPage());
        }
        private async void NavigateTransactionsBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransactionsPage());
        }
    }
}
