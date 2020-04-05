using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellNavigation.Services;
using ShellNavigation.Views;

namespace ShellNavigation
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override async void OnStart()
		{
			//await Shell.Current.GoToAsync("///login");
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
