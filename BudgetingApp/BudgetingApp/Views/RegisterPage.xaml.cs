using BudgetingApp.Models;
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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private void Register_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Navigation.PushModalAsync(new Views.HomePage());
                UserModel user = new UserModel();
                user.Fullname = fullnameEntry.Text;
                user.Email = emailEntry.Text;
                user.Password = passwordEntry.Text;
                user.Username = usernameEntry.Text;
                user.MobileNo = mobilenoEntry.Text;

                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
                {
                    conn.CreateTable<UserModel>();
                    var numberOfRows = conn.Insert(user);

                    if (numberOfRows > 0)
                    {
                        DisplayAlert("Success", "You have registered successfully.", "OK");
                    }
                    else
                    {
                        DisplayAlert("Failed", "Failed to register user.", "Close");
                    }
                }
                
            }
            catch (Exception ex)
            {
                DisplayAlert("Success", ex.Message , "OK");
            }
            
        }
    }
}