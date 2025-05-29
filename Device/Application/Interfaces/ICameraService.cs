using ParkPI.Device.Application.UseCases;


public interface ICameraService
{
    string CapturarPlaca();
    byte[] CapturaImagem();
    bool InicializarCamera();
    void EncerrarCamera();

}