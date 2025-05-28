using ParkPI.Device.Application.UseCases;

namespace ParkPI.GUI.Services
{
    public class EntradaSaidaFacade
    {
        private readonly RegistrarEntradaUseCase _useCase;

        public EntradaSaidaFacade(RegistrarEntradaUseCase useCase)
        {
            _useCase = useCase;
        }

        public void Executar()
        {
            _useCase.Executar(); // ou await, se for async
        }
    }
}
