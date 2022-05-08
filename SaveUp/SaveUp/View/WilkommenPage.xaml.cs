using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveUp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WilkommenPage : ContentPage
    {
        public WilkommenPage()
        {
            InitializeComponent();
        }

        private void btnToMain_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}