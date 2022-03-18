using UnityEngine;

[CreateAssetMenu(fileName = "CharactersCollection", menuName = "DataItems/CharactersCollection")]
public class CharactersCollection : ScriptableObject
{
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private Enemy _enemyPrefab;

    public Player PlayerPrefab => _playerPrefab;
    public Enemy EnemyPrefab => _enemyPrefab;
}