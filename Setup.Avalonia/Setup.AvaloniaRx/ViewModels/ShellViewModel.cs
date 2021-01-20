using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls.Chrome;
using Caliburn.Micro;
using ReactiveUI;

namespace Setup.AvaloniaRx.ViewModels
{
    public class ShellViewModel : Conductor<Screen>.Collection.OneActive
    {
        private ObservableAsPropertyHelper<string> _displayNameRx;

        public ShellViewModel()
        {
            _displayNameRx = this.WhenAnyValue(x => x.DisplayName)
                .Select(s => s + " With ReactiveUI!")
                .ToProperty(this, x => x.DisplayNameRx);
        }

        protected override async Task OnInitializeAsync(CancellationToken cancellationToken)
        {
            await base.OnInitializeAsync(cancellationToken);

            DisplayName = "Welcome to Caliburn.Micro.Avalonia!";
        }

        public string DisplayNameRx => _displayNameRx.Value;
    }
}
