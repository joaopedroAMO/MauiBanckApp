namespace MauiApplogin;

public partial class telaUsuario : ContentPage
{
	public telaUsuario()
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
                lbl_boasvindas.Text = $"Bem vindo {usuario_logado}";
                lbl_email.Text = $"Email: {email_logado}";
            }
        });
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string? senhaApp = null;

        senhaApp = await SecureStorage.Default.GetAsync("senha_app");

        if (txt_senhalogin.Text == senhaApp)
        {
            App.Current.MainPage = new telaDoApp();
        }
        else
        {
            await DisplayAlert("Ops", "A senha está incorreta", "OK");
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        SecureStorage.Default.Remove("usuario_logado");
        SecureStorage.Default.Remove("email_logado");
        SecureStorage.Default.Remove("senha_app");
        App.Current.MainPage = new MainPage();
    }
}