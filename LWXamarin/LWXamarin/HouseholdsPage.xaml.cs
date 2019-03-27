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
	public partial class HouseholdsPage : ContentPage
	{
        public ObservableCollection<Household> Houses { get; set; } = new ObservableCollection<Household>();

        public HouseholdsPage()
        {
            InitializeComponent();
            this.Title = "Simple Financial App";
            getHouseholdsBtn.Clicked += GetHouseholdsBtn_Clicked;
            getMainBtn.Clicked += NavigateHomeBtn_OnClicked;

            MyHouseView.ItemsSource = Houses;
        }

        private async void NavigateHomeBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GetHouseholdsBtn_Clicked(object sender, EventArgs e)
        {
            var data = await Core.GetHouseholds();

            foreach (var item in data)
            {
                Houses.Add(item);
            }
                
            //if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            //{
            //    Household household = await Core.GetHouseholds(zipCodeEntry.Text);
            //    this.BindingContext = household;
            //    getHouseholdsBtn.Text = "Search Again";
            //}
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}