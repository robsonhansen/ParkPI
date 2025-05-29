using ParkPI.Device.Application.UseCases;

public interface IUsuarioRepository
{
    public Usuario ObterUsuario(string username);
    void Salvar(Usuario usuario);
}