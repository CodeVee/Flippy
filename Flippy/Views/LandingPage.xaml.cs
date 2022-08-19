namespace Flippy.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

	void OnPositionChanged(object sender, PositionChangedEventArgs e)
	{
		var position = carousel.Position;

		if (position < 2)
			return;

		carousel.IsSwipeEnabled = false;
        footer.IsVisible = false;
		startBtn.IsVisible = true;
	}

	private void OnSkipButton_Clicked(object sender, EventArgs e)
	{
		carousel.ScrollTo(2);
	}

	private void OnNextButton_Clicked(object sender, EventArgs e)
	{
		var position = carousel.Position;
		if (position > 1)
			return;

		var nextPosition = position + 1;
		carousel.ScrollTo(nextPosition);
	}
}