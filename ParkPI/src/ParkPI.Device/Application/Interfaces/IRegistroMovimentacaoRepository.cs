public interface IRegistroMovimentacaoRepository
{
    void Salvar(RegistroMovimentacao registro);
    IEnumerable<RegistroMovimentacao> ListarTodos();
}
