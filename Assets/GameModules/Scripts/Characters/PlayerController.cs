using UnityEngine;

[RequireComponent(typeof(Player), typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _moveSpeedModifier;
    [SerializeField] private float _rotateSpeedModifier;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var horizontalPointer = Input.GetAxisRaw("Horizontal");
        var verticalPointer = Input.GetAxisRaw("Vertical");
        
        var moveVector = new Vector3(horizontalPointer, 0, verticalPointer) * _moveSpeedModifier;
        
        _characterController.Move(moveVector * Time.deltaTime);
    
        if (moveVector != Vector3.zero)
        {
            var rotateDirection = Quaternion.LookRotation(new Vector3(horizontalPointer, 0, verticalPointer));
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotateDirection, 
                _rotateSpeedModifier * Time.deltaTime);
        }
    }
}