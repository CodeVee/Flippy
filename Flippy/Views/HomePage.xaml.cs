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
}