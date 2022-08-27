namespace Flippy.Views;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}

	private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
		var text = e.NewTextValue.Trim();
		var textlength = text.Length;
		if (textlength == 0)
			clearBtn.IsVisible = false;
		else
			clearBtn.IsVisible = true;
	}

	private void ClearBtn_Clicked(object sender, EventArgs e)
	{
		searchEntry.Text = "";
	}
}