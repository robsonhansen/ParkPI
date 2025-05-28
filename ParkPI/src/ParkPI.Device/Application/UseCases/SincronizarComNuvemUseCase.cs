public class SincronizarComNuvemUseCase
{
    private readonly ISyncService _syncService;

    public SincronizarComNuvemUseCase(ISyncService syncService)
    {
        _syncService = syncService;
    }

    public async Task<bool> ExecutaAsync()
    {
        var conectado = await _syncService.VerificarConectividadeAsync();

        if (!conectado)
            return false;
        var sucesso = await _syncService.SincronizarRegistroAsync();
        return sucesso;
    }
}