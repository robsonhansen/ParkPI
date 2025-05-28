using LiteDB;

public class VeiculoRepository : IVeiculoRepository
{
    private readonly LiteDatabase _database;

    public VeiculoRepository(LiteDatabase database)
    {
        _database = database;
    }

    public Veiculo ObterVeiculo(string placa)
    {
        var collection = _database.GetCollection<Veiculo>("veiculos");
        return collection.FindOne(v => v.Placa == placa);
    }

    public void Salvar(Veiculo veiculo)
    {
        var col = _database.GetCollection<Veiculo>("veiculos");
        col.Upsert(veiculo);
    }

    public IEnumerable<Veiculo> ObterTodos()
    {
        var col = _database.GetCollection<Veiculo>("veiculos");
        return col.FindAll();
    }
}

