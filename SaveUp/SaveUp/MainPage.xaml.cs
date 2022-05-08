using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaveUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Onappearing Methode füllt CollectionView mit gespeicherten Daten
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        // Eingegebene Inhalt in der Datenbank speicher Methode
        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(beschreibungEntry.Text) && !string.IsNullOrWhiteSpace(geldEntry.Text))
            {
                await App.Database.SaveListeAsync(new Liste
                {
                    Beschreibung = beschreibungEntry.Text,
                    Geld = int.Parse(geldEntry.Text)
                });

                beschreibungEntry.Text = geldEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
