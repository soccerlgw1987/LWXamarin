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
	public partial class TransactionsPage : ContentPage
	{
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();

        public TransactionsPage ()
		{
			InitializeComponent ();
            this.Title = "Simple Financial App";
            getTransactionsBtn.Clicked += GetTransactionsBtn_Clicked;
            getMainBtn.Clicked += NavigateHomeBtn_OnClicked;

            MyTransactionView.ItemsSource = Transactions;
        }

        private async void NavigateHomeBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GetTransactionsBtn_Clicked(object sender, EventArgs e)
        {
            var data = await Core.GetTransactions();

            foreach (var item in data)
            {
                Transactions.Add(item);
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