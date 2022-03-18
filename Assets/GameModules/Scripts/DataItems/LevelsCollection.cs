using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelsCollection", menuName = "DataItems/LevelsCollection")]
public class LevelsCollection : ScriptableObject
{
    [SerializeField] private List<Level> _levelPrefabs;

    public List<Level> LevelPrefabs => _levelPrefabs;
}