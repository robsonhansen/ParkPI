public class Configuracao
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public int TempoMaximoPermanenciaMin { get; set; }
    public bool HabilitarSincronizacao { get; set; }
    public int IntervaloSyncMinutos { get; set; }
    public bool ReconhecimentoAutomatico { get; set; }

    public int PortaGpioEntrada { get; set; }
    public int PortaGpioSaida { get; set; }

    public string? UrlServidoRemoto { get; set; }
    public string? UrlServidorLocal { get; set; }

    public DateTime UltimaAlteracao { get; private set; } = DateTime.UtcNow;


    public void AtualizacaoConfiguracao(Configuracao novaConfig)
    {
        TempoMaximoPermanenciaMin = novaConfig.TempoMaximoPermanenciaMin;
        HabilitarSincronizacao = novaConfig.HabilitarSincronizacao;
        IntervaloSyncMinutos = novaConfig.IntervaloSyncMinutos;
        ReconhecimentoAutomatico = novaConfig.ReconhecimentoAutomatico;
        PortaGpioEntrada = novaConfig.PortaGpioEntrada;
        PortaGpioSaida = novaConfig.PortaGpioSaida;
        UrlServidoRemoto = novaConfig.UrlServidoRemoto;
        UrlServidorLocal = novaConfig.UrlServidorLocal;
        UltimaAlteracao = DateTime.UtcNow;
    }

    public void Valida()
    {
        if (TempoMaximoPermanenciaMin < 0)
            throw new Exception("Tempo máximo de permanência inválido");
        if (IntervaloSyncMinutos < 0)
            throw new Exception("Intervalo de sincronização inválido");
        if (PortaGpioEntrada < 0)
            throw new Exception("Porta GPIO de entrada inválida");
        if (PortaGpioSaida < 0)
            throw new Exception("Porta GPIO de saída inválida");
    }

    public void ConfigPadrao()
    {
        TempoMaximoPermanenciaMin = 0;
        HabilitarSincronizacao = false;
        IntervaloSyncMinutos = 0;
        ReconhecimentoAutomatico = false;
        PortaGpioEntrada = 0;
        PortaGpioSaida = 0;
        UrlServidoRemoto = "";
        UrlServidorLocal = "";
    }



}