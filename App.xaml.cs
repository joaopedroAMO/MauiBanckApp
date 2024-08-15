namespace MauiApplogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string? usuario_logado = null;

            Task.Run(async () =>
            {
                usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");

                if (usuario_logado != null)
                {
                    MainPage = new telaUsuario();
                }
                else
                {
                    MainPage = new MainPage();
                }
            });
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            // Crie a janela com a página inicial
            var window = base.CreateWindow(activationState);

            // Defina as dimensões da janela, se aplicável
            window.Width = 400;

            return window;
        }
    }
}
