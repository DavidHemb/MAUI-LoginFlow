using MauiLoginFlow.Services;
namespace MauiLoginFlow.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly AuthService _authService;
    public RegisterPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        var response = _authService.Register(username, password);
        if (response)
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");
        else
            await DisplayAlert("Error", "Invalid username or password", "OK");
    }
}