using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LWXamarin
{
	public partial class AccountDetailsPage : ContentPage
	{
        public AccountDetailsPage()
        {
            InitializeComponent();
            this.Title = "Simple Financial App";
            getAccountDetailsBtn.Clicked += GetAccountDetailsBtn_Clicked;
            getMainBtn.Clicked += NavigateHomeBtn_OnClicked;

            this.BindingContext = new Account();
        }

        private async void NavigateHomeBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GetAccountDetailsBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(accountIdEntry.Text))
            {
                Account account = await Core.GetAccountDetails(accountIdEntry.Text);
                this.BindingContext = account;
                getAccountDetailsBtn.Text = "Search Again";
            }
        }
    }
}