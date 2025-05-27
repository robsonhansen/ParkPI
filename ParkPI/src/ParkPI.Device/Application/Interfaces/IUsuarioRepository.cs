public interface IUsuarioRepository
{
    Usuario ObterPorUsuario(string username);
    void Salvar(Usuario usuario);
}