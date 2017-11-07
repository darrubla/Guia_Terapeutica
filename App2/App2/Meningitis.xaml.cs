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
	public partial class Meningitis : ContentPage
	{
		public Meningitis ()
		{
			InitializeComponent ();
		}

        private void Meningitis_Aguda_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Meningitis_Aguda());
        }

        private void Meningitis_Aguda_Viral_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Meningitis_Aguda_Viral());
        }

        private void Tratamiento_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Tratamiento());
        }

        private void Corticoides_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Corticoides());
        }
    }
}