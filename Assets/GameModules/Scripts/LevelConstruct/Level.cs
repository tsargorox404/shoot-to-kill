using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    public List<SpawnPoint> SpawnPoints => _spawnPoints;

    public void RefreshSpawnPoints()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            spawnPoint.gameObject.SetActive(true);
        }
        
        ShuffleSpawnPoints();
    }
    
    private void ShuffleSpawnPoints()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            var temp = _spawnPoints[i];
            var j = Random.Range(0, _spawnPoints.Count);
            
            _spawnPoints[i] = _spawnPoints[j];
            _spawnPoints[j] = temp;
        }
    }
}