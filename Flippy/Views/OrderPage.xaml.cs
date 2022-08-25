namespace Flippy.Views;

public partial class OrderPage : ContentPage
{
	public OrderPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("");
	}
}