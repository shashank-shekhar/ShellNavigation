using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellNavigation.ViewModels
{
	public class LoginPageViewModel : BaseViewModel
	{
		private string _email;
		private string _password;

		public LoginPageViewModel()
		{
			Title = "Login";
		}


		public string Email
		{
			get => _email;
			set => SetProperty(ref _email , value);
		}

		public string Password
		{
			get => _password;
			set => SetProperty(ref _password , value);
		}

		public Command LoginCommand => new Command(async()=> await LoginAsync());

		private async Task LoginAsync()
		{
			await Shell.Current.GoToAsync("///main");
		}
	}
}