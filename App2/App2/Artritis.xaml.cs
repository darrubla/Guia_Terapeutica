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
	public partial class Artritis : ContentPage
	{
		public Artritis ()
		{
			InitializeComponent ();
		}

        private void liquido_Sinivial_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Liquido_Sinival());
        }

        private void liquido_Sinivial_Mas_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Liquido_Sinivial_Mas());
        }

        private void Liquido_Sinivial_Bacilos_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Liquido_Sinivial_Bacilos());
        }

        private void Empirico_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Empirico());
        }
    }
}