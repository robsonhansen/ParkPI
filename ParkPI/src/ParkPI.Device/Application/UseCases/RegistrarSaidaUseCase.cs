public class RegistrarSaidaUseCase
{
    private readonly ICameraService _cameraService;
    private readonly IHardwareManager _hardwareManager;
    private readonly IVeiculoRepository _veiculoRepository;
    private readonly IRegistroMovimentacaoRepository _registroRepository;

    public RegistrarSaidaUseCase(
        ICameraService cameraService,
        IHardwareManager hardwareManager,
        IVeiculoRepository veiculoRepository,
        IRegistroMovimentacaoRepository registroRepository)
    {
        _cameraService = cameraService;
        _hardwareManager = hardwareManager;
        _veiculoRepository = veiculoRepository;
        _registroRepository = registroRepository;
    }

    public void Executar()
    {
        var placa = _cameraService.CapturarPlaca();
        var veiculo = _veiculoRepository.ObterVeiculo(placa);

        if (veiculo == null)
        {
            throw new Exception("Veiculo não encontrado");
        }

        var registro = new RegistroMovimentacao(placa, TipoMovimentacao.Entrada, "");

        _registroRepository.Salvar(registro);

        _hardwareManager.AbrirCancelaEntrada();
    }
}