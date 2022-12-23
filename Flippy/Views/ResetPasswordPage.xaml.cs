namespace Flippy.Views;

public partial class ResetPasswordPage : ContentPage
{
	public ResetPasswordPage()
	{
		InitializeComponent();
	}

    private void ToggleNewPasswordButton_Clicked(object sender, EventArgs e)
    {
        newPasswordEntry.IsPassword = !newPasswordEntry.IsPassword;
    }

    private void ToggleConfirmPasswordButton_Clicked(object sender, EventArgs e)
    {
        confirmPasswordEntry.IsPassword = !confirmPasswordEntry.IsPassword;
    }
}