using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetingApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent();
		}

        private void LoginTapped()
        {            
            Navigation.PushModalAsync(new MainPage());
        }
        
        private void RegisterTapped()
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}