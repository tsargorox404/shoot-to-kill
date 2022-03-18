using GameModules.Scripts.Ui.Installer;
using Zenject;

namespace GameModules.Scripts
{
    public class StartupInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            DataItemsInstaller.Install(Container);
            UiInstaller.Install(Container);
            CoreGameInstaller.Install(Container);
        }
    }
}