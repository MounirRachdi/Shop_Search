using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Shop_Search
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Shop_Search.MainPage();
            MainPage = new Views.ShopPage();
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
