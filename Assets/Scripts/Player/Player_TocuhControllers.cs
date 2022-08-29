using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_TocuhControllers : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Joystick joystick;
    [SerializeField] private float movementspeed;
    [SerializeField] private float rotationspeed = 500;

    public Rigidbody rb;

    private Touch _touch;
    private Vector3 touchDown;
    private Vector3 touchUp;
    private bool dragStarted;
 
    void Update()
    {
        if(joystick.Direction.magnitude > 0.1f){
            _animator.SetBool("IsMoving",true);
            Vector3 direction = new Vector3(joystick.Horizontal,0,joystick.Vertical);
            var LookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation,LookRotation,Time.deltaTime*rotationspeed);
            _characterController.SimpleMove(transform.forward * movementspeed);
        }
        else _animator.SetBool("IsMoving",false);
    }
}
