using ParkPI.Device.Application.UseCases;

public interface IVeiculoRepository
{
    Veiculo ObterVeiculo(string placa);
    void Salvar(Veiculo veiculo);
    IEnumerable<Veiculo> ObterTodos();
}
