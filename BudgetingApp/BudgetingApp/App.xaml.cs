using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BudgetingApp
{
	public partial class App : Application
	{
        public static string DB_PATH = string.Empty;
		public App ()
		{
			InitializeComponent();

			MainPage = new Views.HomePage();
		}

        public App(string db_path)
        {
            InitializeComponent();

            DB_PATH = db_path;

            MainPage = new Views.HomePage();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
