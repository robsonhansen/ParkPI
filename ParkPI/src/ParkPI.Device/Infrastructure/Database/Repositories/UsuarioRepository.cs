using System.ComponentModel;

public class UsuarioReportory : IUsuarioRepository
{
    private readonly LiteDataBase _dataBase;

    public UsuarioReportory(LiteDataBase dataBase)
    {
        _dataBase = dataBase;
    }

    public Usuario ObterUsuario(string username)
    {
        var col = _dataBase.GetCollection<Usuario>();
        return col.FindOne(u => u.Username == username);
    }

    public void Salvar(Usuario usuario)
    {
        var col = _dataBase.GetCollection<Usuario>("usuarios");
        col.Upsert(usuario);
    }

    public IEnumerable<Usuario> ObterTodos()
    {
        var col = _dataBase.GetCollection<Usuario>("usuarios");
        return col.FindAll();
    }
}