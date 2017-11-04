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
	public partial class Otitis : ContentPage
	{
		public Otitis ()
		{
			InitializeComponent ();
		}

        private void Otitis_Cronica_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Otitis_Cronica());
        }
    }
}