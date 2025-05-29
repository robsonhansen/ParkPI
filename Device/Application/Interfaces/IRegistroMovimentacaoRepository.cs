using ParkPI.Device.Application.UseCases;

public interface IRegistroMovimentacaoRepository
{
    void Salvar(RegistroMovimentacao registro);
    IEnumerable<RegistroMovimentacao> ObterTodos();
}
