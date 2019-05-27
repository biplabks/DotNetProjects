using Caliburn.Micro;
using System.Windows;
using WPFDemoDataGrid.ViewModels;

namespace WPFDemoDataGrid
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
