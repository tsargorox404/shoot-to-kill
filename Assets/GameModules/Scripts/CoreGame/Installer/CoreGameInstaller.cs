using Zenject;

public class CoreGameInstaller : Installer<CoreGameInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<LevelDirector>().AsSingle();
        Container.Bind<CharactersDirector>().AsSingle();
    }
}