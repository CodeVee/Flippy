namespace Flippy.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

	private async void EditButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(ProfileEditPage));
	}
}