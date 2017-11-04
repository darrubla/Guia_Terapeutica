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
	public partial class Liquido_Sinivial_Bacilos : ContentPage
	{
		public Liquido_Sinivial_Bacilos ()
		{
			InitializeComponent ();
		}

        private void Inmunodeprimido_Si_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Inmunodeprimido_Si());
        }

        private void Inmunodeprimido_No_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Inmunodeprimido_No());
        }
    }
}