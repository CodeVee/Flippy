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

	private async void WishlistButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(WishlistPage));
    }

    private async void AddressButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddressPage));
    }

    private async void OrderButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(OrderPage));
    }

    private async void BlogButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BlogPage));
    }
}