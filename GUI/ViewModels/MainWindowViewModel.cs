using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;

namespace ParkPI.GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _resultado;
        public string Resultado
        {
            get => _resultado;
            set => this.RaiseAndSetIfChanged(ref _resultado, value);
        }

        public ReactiveCommand<Unit, Unit> RegistrarEntradaCommand { get; }

        public MainWindowViewModel()
        {
            RegistrarEntradaCommand = ReactiveCommand.CreateFromTask(RegistrarEntradaAsync);
        }

        private async Task RegistrarEntradaAsync()
        {
            // Aqui você chamaria o UseCase do ParkPI.Device.Application
            Resultado = "Entrada registrada com sucesso!";
        }
    }
}
