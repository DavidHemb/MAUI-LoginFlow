using MauiLoginFlow.Services;
namespace MauiLoginFlow.Pages;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;
    public LoadingPage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (await _authService.IsAuthorizedAsync())
        {
            Shell.Current.GoToAsync($"//{nameof(MainPage)}");

        }
        else
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}