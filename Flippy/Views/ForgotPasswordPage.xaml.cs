namespace Flippy.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}

	private async void SubmitButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(ResetPasswordPage));
	}
}