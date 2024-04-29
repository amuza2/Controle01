namespace ControleDamMedChami;

public partial class Bravo : ContentPage
{
	public Bravo()
	{
		InitializeComponent();
		lblCounter.Text = Hello.LoginSuccessCounter.ToString();
	}
}