using Flippy.Views;

namespace Flippy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
		Routing.RegisterRoute(nameof(ResetPasswordPage), typeof(ResetPasswordPage));
		Routing.RegisterRoute(nameof(ProductListPage), typeof(ProductListPage));
		Routing.RegisterRoute(nameof(ProfileEditPage), typeof(ProfileEditPage));
        Routing.RegisterRoute(nameof(WishlistPage), typeof(WishlistPage));
		Routing.RegisterRoute(nameof(AddressPage), typeof(AddressPage));
		Routing.RegisterRoute(nameof(AddressFormPage), typeof(AddressFormPage));
		Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
		Routing.RegisterRoute(nameof(ReviewPage), typeof(ReviewPage));
    }
}
