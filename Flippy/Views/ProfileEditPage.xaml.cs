namespace Flippy.Views;

public partial class ProfileEditPage : ContentPage
{
	public ProfileEditPage()
	{
		InitializeComponent();
		CancelBtn.Command = new Command(() => ReturnToProfile());
	}

	private static async void ReturnToProfile()
	{
		await Shell.Current.GoToAsync("..");
	}

	private async void CloseBtn_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}