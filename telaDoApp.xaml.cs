namespace MauiApplogin;

public partial class telaDoApp : ContentPage
{
	public telaDoApp()
	{
		InitializeComponent();

		
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		var eyeIcon = Eyeicon.Source as FileImageSource;
		if (eyeIcon != null && eyeIcon.File == "olho.png")
		{
            Eyeicon.Source = "olho_fechado.png";
			txt_salddo.Text = "••••";
			txt_pontos.Text = "••••";

        }
		else
		{
			Eyeicon.Source = "olho.png";
			txt_salddo.Text = "00,00";
			txt_pontos.Text = "22";
		}
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new telaDePerfil();
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
		App.Current.MainPage =  new pixPage();
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
		App.Current.MainPage = new cardPage();
    }

    private void brasil_taped(object sender, EventArgs e)
	{
		frame_brasil.BackgroundColor = Colors.White;
		frame_eua.BackgroundColor = Colors.Transparent;
		money_type.Text = "R$";
	}

    private void eua_taped(object sender, EventArgs e)
    {
        frame_brasil.BackgroundColor = Colors.Transparent;
		frame_eua.BackgroundColor = Colors.White;
		money_type.Text = "US$";
    }
}