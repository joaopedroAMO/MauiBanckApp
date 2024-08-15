namespace MauiApplogin;

public partial class telaDePerfil : ContentPage
{
	public telaDePerfil()
	{
		InitializeComponent();

        string? usuario_logado = null;
        string? email_logado = null;

        Task.Run(async () =>
        {
            usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
            email_logado = await SecureStorage.Default.GetAsync("email_logado");

            if (usuario_logado != null)
            {
                usernamePerfil.Text = usuario_logado;
                userEmail.Text = email_logado;
            }
        });
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new telaDoApp();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        bool confimasao = await DisplayAlert("Atenção", "Deseja mesmo sair da sua conta?", "Sim", "Não");

        if (confimasao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            SecureStorage.Default.Remove("email_logado");
            SecureStorage.Default.Remove("senha_app");
            App.Current.MainPage = new MainPage();
        }
    }
}