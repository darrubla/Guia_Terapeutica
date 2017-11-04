using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Osteomusculares : ContentPage
	{
		public Osteomusculares ()
		{
			InitializeComponent ();
		}
        private void Artritis_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Artritis());
        }

        private void Espondilodiscitis_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Espondilodiscitis());
        }

        private void Osteomielitis_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Osteomielitis());
        }

    }
}