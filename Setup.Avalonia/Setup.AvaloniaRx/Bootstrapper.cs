using Caliburn.Micro;
using Setup.AvaloniaRx.ViewModels;

namespace Setup.AvaloniaRx
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
            
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
