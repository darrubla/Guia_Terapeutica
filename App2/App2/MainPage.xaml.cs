using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Bucofaringeo_OnClicked(object sender, System.EventArgs e)
        {
            
            Navigation.PushAsync(new Bucofaringeos());
        }

        private void Osteomusculares_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Osteomusculares());
        }

        private void Otitis_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Otitis());
        }

        private void Cerebral_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Cerebral());
        }
    }
}
