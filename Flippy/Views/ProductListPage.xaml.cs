namespace Flippy.Views;

[QueryProperty(nameof(PageTitle), "PageTitle")]
public partial class ProductListPage : ContentPage
{
    string pageTitle;
    public string PageTitle
    {
        get => pageTitle;
        set
        {
            pageTitle = value;
            titleLbl.Text = value;
            OnPropertyChanged();
        }
    }
    public ProductListPage()
	{
		InitializeComponent();
	}
}