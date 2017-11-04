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
	public partial class Liquido_Sinivial_Mas : ContentPage
	{
		public Liquido_Sinivial_Mas ()
		{
			InitializeComponent ();
		}

        private void SARM_Si_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new SARM_Si());
        }

        private void SARM_No_OnClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new SARM_No());
        }
    }
}