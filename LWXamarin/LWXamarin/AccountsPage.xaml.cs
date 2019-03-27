using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LWXamarin
{
	public partial class AccountsPage : ContentPage
	{
        public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>();

        public AccountsPage()
        {
            InitializeComponent();
            this.Title = "Simple Financial App";
            getAccountsBtn.Clicked += GetAccountsBtn_Clicked;
            getMainBtn.Clicked += NavigateHomeBtn_OnClicked;

            MyAccountView.ItemsSource = Accounts;
        }

        private async void NavigateHomeBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GetAccountsBtn_Clicked(object sender, EventArgs e)
        {
            var data = await Core.GetAccounts();

            foreach (var item in data)
            {
                Accounts.Add(item);
            }
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}