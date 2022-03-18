using System.Collections.Generic;
using UnityEngine;

public class CharactersDirector : ILoader
{
    private List<Character> _characters;
    private CharactersCollection _charactersCollection;
    private LevelDirector _levelDirector;

    public Player Player { get; private set; }
    public Enemy Enemy { get; private set; }

    private CharactersDirector(CharactersCollection charactersCollection, LevelDirector levelDirector)
    {
        _charactersCollection = charactersCollection;
        _levelDirector = levelDirector;
    }
    
    public void Load()
    {
        _characters = new List<Character>();
        
        Player = Object.Instantiate(_charactersCollection.PlayerPrefab);
        Enemy = Object.Instantiate(_charactersCollection.EnemyPrefab);
        
        _characters.Add(Player);
        _characters.Add(Enemy);

        foreach (var character in _characters)
        {
            character.gameObject.SetActive(false);
        }
    }

    public void SetCharacters()
    {
        var level = _levelDirector.Level;
        
        foreach (var character in _characters)
        {
            for (int i = 0; i < level.SpawnPoints.Count; i++)
            {
                if (level.SpawnPoints[i].gameObject.activeSelf)
                {
                    character.transform.position = level.SpawnPoints[i].transform.position;
                    character.transform.SetParent(level.transform);
                    character.gameObject.SetActive(true);
                    level.SpawnPoints[i].gameObject.SetActive(false);
                    i = level.SpawnPoints.Count;
                }
            }
        }
    }
}
