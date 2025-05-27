public class Veiculo
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Placa { get; set; }
    public string? Modelo { get; set; }
    public string? Cor { get; set; }

    public DateTime CadastroEm { get; private set; } = DateTime.UtcNow;

    public Guid? UsuarioId { get; set; }
}