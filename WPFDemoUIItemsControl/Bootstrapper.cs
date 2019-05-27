using Caliburn.Micro;
using System.Windows;
using WPFDemoUIItemsControl.ViewModels;

namespace WPFDemoUIItemsControl
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
