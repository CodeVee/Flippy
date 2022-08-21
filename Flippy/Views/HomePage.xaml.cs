using Flippy.Models;

namespace Flippy.Views;

public partial class HomePage : ContentPage
{
	public List<Product> Products { get; set; }
	public HomePage()
	{
		InitializeComponent();
		LoadProducts();
	}

	private void LoadProducts()
	{
		Products = new()
		{
			new() { Name = "Mushrooms", Price = 150, Weight = "1KG" , ImageSource = "mushroom.png" },
            new() { Name = "Mushrooms", Price = 150, Weight = "1KG" , ImageSource = "mushroom.png" },
            new() { Name = "Mushrooms", Price = 150, Weight = "1KG" , ImageSource = "mushroom.png" },
            new() { Name = "Mushrooms", Price = 150, Weight = "1KG" , ImageSource = "mushroom.png" },
        };
	}

	private async void AllButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync($"//{nameof(CategoryPage)}");
	}

    private async void BestSellerButton_Clicked(object sender, EventArgs e)
    {
        var pageTitle = "Best Sellers";
        var navigationParameter = new Dictionary<string, object>
        {
            { "PageTitle", pageTitle }
        };
        await Shell.Current.GoToAsync(nameof(ProductListPage), navigationParameter);
    }

    private async void FruitButton_Clicked(object sender, EventArgs e)
    {
        var pageTitle = "Fruits";
        var navigationParameter = new Dictionary<string, object>
        {
            { "PageTitle", pageTitle }
        };
        await Shell.Current.GoToAsync(nameof(ProductListPage), navigationParameter);
    }
}