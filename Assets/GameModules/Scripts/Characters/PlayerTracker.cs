using UnityEngine;
using Zenject;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Vector3 _defaultPosition;
    [SerializeField] private float _moveSpeed;

    private CharactersDirector _charactersDirector;
    private Player _player;

    [Inject]
    private void Construct(CharactersDirector charactersDirector)
    {
        _charactersDirector = charactersDirector;
    }

    private void Start()
    {
        _player = _charactersDirector.Player;
        SetCamera();
    }

    private void FixedUpdate()
    {
        if (new Vector3(_player.transform.position.x, 0, _player.transform.position.z) != Vector3.zero)
            SetPosition();
    }

    private void SetPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            _player.transform.position + _defaultPosition, _moveSpeed * Time.deltaTime);
    }
    
    private void SetCamera()
    {
        transform.position = _player.transform.position + _defaultPosition;
        SetPosition();
    }
}