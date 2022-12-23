namespace Flippy.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	private async void LoginButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(LoginPage));
	}
}