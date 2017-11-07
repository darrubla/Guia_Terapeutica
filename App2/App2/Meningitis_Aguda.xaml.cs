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
	public partial class Meningitis_Aguda : ContentPage
	{
		public Meningitis_Aguda ()
		{
			InitializeComponent ();
		}


        private void Corticoides_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Corticoides());
        }
    }
}