using System.Data;

public class RegistrarEntradaUseCase
{
    private readonly ICameraService _cameraService;
    private readonly IHardwareManager _hardwareManager;
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IVeiculoRepository _veiculoRepository;
    private readonly IRegistroMovimentacaoRepository _registroRepository;

    public RegistrarEntradaUseCase(ICameraService cameraService, IHardwareManager hardwareManager, IUsuarioRepository usuarioRepository, IVeiculoRepository veiculoRepository, IRegistroMovimentacaoRepository registroRepository)
    {
        _cameraService = cameraService;
        _hardwareManager = hardwareManager;
        _usuarioRepository = usuarioRepository;
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