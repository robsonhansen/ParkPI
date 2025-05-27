public class AutenticarUsuarioUseCase
{
    private readonly IUserAuthService _authService;

    public AutenticarUsuarioUseCase(IUserAuthService authService)
    {
        _authService = authService;
    }

    public bool Executar(string usuario, string senha)
    {
        return _authService.Autenticar(usuario, senha);
    }
}
