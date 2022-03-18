using UnityEngine;
using Zenject;

public class GameLoader: MonoBehaviour
{
   private LevelDirector _levelDirector;
   private CharactersDirector _charactersDirector;
   
   [Inject]
   private void Construct(LevelDirector levelDirector, CharactersDirector charactersDirector)
   {
      _levelDirector = levelDirector;
      _charactersDirector = charactersDirector;
   }

   private void Awake()
   {
      _levelDirector.Load();
      _charactersDirector.Load();
   }

   private void Start()
   {
      _levelDirector.Level.gameObject.SetActive(true);
      _charactersDirector.SetCharacters();
   }
}