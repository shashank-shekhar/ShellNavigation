using ShellNavigation.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

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
			string value = await SecureStorage.GetAsync("loggedIn");
			if (value == "1")
			{
				await Shell.Current.GoToAsync("///main");
			}
			else
			{
				await Shell.Current.GoToAsync("///login");
			}
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
