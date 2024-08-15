namespace MauiApplogin;

public partial class pixPage : ContentPage
{
	public pixPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked_voltar(object sender, EventArgs e)
    {
		App.Current.MainPage = new telaDoApp();
    }
}