namespace Flippy.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void TogglePasswordButton_Clicked(object sender, EventArgs e)
	{
		passwordEntry.IsPassword = !passwordEntry.IsPassword;
	}

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    private async void ForgotButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ForgotPasswordPage));
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}