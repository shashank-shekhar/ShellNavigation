using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellNavigation.ViewModels
{
	public class LoginPageViewModel : BaseViewModel
	{
		private string _email;
		private string _password;
		private string _validationError;

		public LoginPageViewModel()
		{
			Title = "Login";
		}


		public string Email
		{
			get => _email;
			set => SetProperty(ref _email, value);
		}

		public string Password
		{
			get => _password;
			set => SetProperty(ref _password, value);
		}

		public string ValidationError
		{
			get => _validationError;
			set => SetProperty(ref _validationError, value);
		}

		public Command LoginCommand => new Command(async () => await LoginAsync());

		private async Task LoginAsync()
		{
			if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				ValidationError = "Email and password are required";
				return;
			}
			else
			{
				await SecureStorage.SetAsync("loggedIn", "1");
			}
			await Shell.Current.GoToAsync("///main");
		}
	}
}