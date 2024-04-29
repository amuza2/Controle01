namespace ControleDamMedChami;

public partial class Hello : ContentPage
{
    string Loginpassword = "DAM2024";
	public static int LoginSuccessCounter { get; set; } = 1;
    public Hello()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		if(inputPassword.Text == Loginpassword)
		{
			await Navigation.PushAsync(new Bravo());
			Hello.LoginSuccessCounter++;
		}
		else
		{
			await DisplayAlert("Error password", "Password not valid", "Ok");
		}
    }
}