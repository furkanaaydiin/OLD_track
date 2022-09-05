using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_TouchContolllers : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Joystick joystick;
    [SerializeField] private float movementspeed;
    [SerializeField] private float rotationspeed = 500;
    private Touch _touch;
    private Vector3 touchDown;
    private Vector3 touchUp;
    private bool dragStarted;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if(joystick.Direction.magnitude > 0.1f){
            _animator.SetBool("IsMoving",true);
            Vector3 direction = new Vector3(joystick.Horizontal,0,joystick.Vertical);
            var LookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation,LookRotation,Time.deltaTime*rotationspeed);
            _rigidbody.MovePosition(transform.position + transform.forward*movementspeed * Time.fixedDeltaTime);
           if(_rigidbody.velocity.magnitude > 5)
           {
                _rigidbody.velocity = _rigidbody.velocity.normalized *5;
           }
        }
        else _animator.SetBool("IsMoving",false);
        
    }
}
