namespace MauiApplogin;

public partial class cardPage : ContentPage
{
	public cardPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new telaDoApp();

    }
}