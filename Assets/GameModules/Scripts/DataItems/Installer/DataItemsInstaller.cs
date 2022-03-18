using Zenject;

public class DataItemsInstaller : Installer<DataItemsInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<LevelsCollection>().FromScriptableObjectResource("DataItems/LevelsCollection").AsSingle();
        Container.Bind<CharactersCollection>().FromScriptableObjectResource("DataItems/CharactersCollection").AsSingle();
    }
}