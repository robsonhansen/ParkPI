public class RegistroMovimentacao
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string PlacaVeiculo { get; set; }

    public TipoMovimentacao Tipo { get; set; }
    public DateTime DataHora { get; set; } = DateTime.UtcNow;

    public string FotoPlacaPath { get; set; }
    public bool Sincronizado { get; set; } = false;

    public RegistroMovimentacao(string placaVeiculo, TipoMovimentacao tipo, string fotoPath)
    {
        PlacaVeiculo = placaVeiculo;
        Tipo = tipo;
        FotoPlacaPath = fotoPath;
    }

    public void MarcarComoSincronizado()
    {
        Sincronizado = true;
    }
}