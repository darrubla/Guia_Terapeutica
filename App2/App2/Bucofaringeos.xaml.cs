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
	public partial class Bucofaringeos : ContentPage
	{
		public Bucofaringeos ()
		{
			InitializeComponent ();
		}

        private void Infeccion_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Infeccion_Odontogenica());
        }
    }
}