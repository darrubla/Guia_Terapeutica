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
	public partial class Cerebral : ContentPage
	{
		public Cerebral ()
		{
			InitializeComponent ();
		}

        private void Absceso_OnClicked (object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Absceso());
        }

        private void Meningitis_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Meningitis());
        }
    }
}