using ParkPI.Device.Application.UseCases;

public interface IUserAuthService
{
    bool Autenticar(string email, string senha);
    void Deslogar();

    Usuario ObterUsuarioLogado();
    bool UsuarioTemPermissao(PerfilUsuario perfilNecessario);
}