
using System;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using Modules.Views;

namespace Modules
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    internal partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //register class object here
            //containerRegistry.RegisterInstance<ShellView>(_tempShellView);
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
            //return  new DirectoryModuleCatalog() {  ModulePath = Environment.CurrentDirectory };
        }
    }
}
