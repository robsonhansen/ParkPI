using LiteDB;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly LiteDatabase _dataBase;

    public UsuarioRepository(LiteDB.LiteDatabase dataBase)
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