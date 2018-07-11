using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BudgetingApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void Access_DB()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                /* conn.CreateTable<"class">();
                   conn.Insert("object");
                
                */
            }
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.HomePage());
        }
        
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.HomePage());
        }
    }
}
