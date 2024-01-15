using MauiLoginFlow.Models.ViewModels;
using MauiLoginFlow.Services;
namespace MauiLoginFlow.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly AuthService _authService;
    public ProfilePage(AuthService authService)
    {
        InitializeComponent();
        BindingContext = new ProfilePageViewModel();
        _authService = authService;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        _authService.Logout();
        Shell.Current.GoToAsync($"{nameof(LoginPage)}");
    }
}