public interface ISyncService
{
    Task<bool> SincronizarRegistroAsync(); //envia dados offline para o servidor ou nuvem
    Task<bool> BaixarConfiguracoesAsync(); //Puxa config remotas
    Task<bool> VerificarConectividadeAsync(); //Verifica se há rede
}