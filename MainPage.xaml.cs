namespace MauiApplogin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                List<dadosUsuario> lista_usuarios = new List<dadosUsuario>()//adicionando  usuarios a lista
                {
                    new dadosUsuario()
                    {
                        usuario = "jonas",
                        senha = "123"
                    },

                    new dadosUsuario()
                    {
                        usuario = "guilherme",
                        senha="1234"
                    },

                    new dadosUsuario()
                    {
                        usuario = "user",
                        senha = "12345"
                    }
                };

                dadosUsuario dados_digitados = new dadosUsuario()//resgatando os dados digitados pelo usuario
                {
                    usuario = txt_usuario.Text,
                    senha = txt_senha.Text
                };

                //biblioteca LINQ
                if (lista_usuarios.Any(i => (dados_digitados.usuario == i.usuario &&
                                            dados_digitados.senha == i.senha)))
                {
                    //salvando o usuario logado no SECURYT STORAGE
                    await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.usuario);

                    //salvando email e senha do app no securyt storage
                    await SecureStorage.Default.SetAsync("email_logado", txt_email.Text);
                    await SecureStorage.Default.SetAsync("senha_app", txt_senhaapp.Text);

                    //alterando a tela
                    App.Current.MainPage = new telaUsuario();
                    
                }
                else
                {
                    throw new Exception("senha ou usuario incorretos");
                }
                //fim biblioteca LINQ

                


            }catch(Exception ex)
            {
                await DisplayAlert("ops", ex.Message, "ok");
                txt_usuario.Focus();
                txt_usuario.Text = string.Empty;
                txt_senha.Text = string.Empty;
            }
        }
    }

}
