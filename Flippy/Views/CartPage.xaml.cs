namespace Flippy.Views;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ProductDetailPage));
	}
}