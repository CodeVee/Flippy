namespace Flippy.Views;

public partial class AddressPage : ContentPage
{
	public AddressPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(AddressFormPage));
	}
}