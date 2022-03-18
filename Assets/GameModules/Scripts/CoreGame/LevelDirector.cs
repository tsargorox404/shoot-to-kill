using UnityEngine;

public class LevelDirector : ILoader
{
    private LevelsCollection _levelsCollection;
    
    public Level Level { get; private set; }

    private LevelDirector(LevelsCollection levelsCollection)
    {
        _levelsCollection = levelsCollection;
    }
    
    public void Load()
    {
        Level = Object.Instantiate(_levelsCollection.LevelPrefabs[Random.Range(0, _levelsCollection.LevelPrefabs.Count)]);
        Level.gameObject.SetActive(false);
    }
}