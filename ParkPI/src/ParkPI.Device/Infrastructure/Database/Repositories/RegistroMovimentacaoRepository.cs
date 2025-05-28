using LiteDB;

public class RegistroMovimentacaoRepository : IRegistroMovimentacaoRepository
{
    private readonly LiteDatabase _database;

    public RegistroMovimentacaoRepository(LiteDatabase database)
    {
        _database = database;
    }

    public void Salvar(RegistroMovimentacao registro)
    {
        var col = _database.GetCollection<RegistroMovimentacao>("movimentacoes");
        col.Insert(registro);
    }

    public IEnumerable<RegistroMovimentacao> ObterTodos()
    {
        var col = _database.GetCollection<RegistroMovimentacao>("movimentacoes");
        return col.FindAll();
    }
}