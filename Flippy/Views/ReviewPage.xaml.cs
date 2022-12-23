namespace Flippy.Views;

public partial class ReviewPage : ContentPage
{
	public ReviewPage()
	{
		InitializeComponent();
	}

	private async void CloseBtn_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..");
    }
}