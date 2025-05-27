public interface IHardwareManager
{
    void AbrirCancelaEntrada();
    void AbrirCancelaSaida();
    bool LerSensorEntrada();
    bool LerSensorSaida();
    bool VerificarStatusDispositivos();
}