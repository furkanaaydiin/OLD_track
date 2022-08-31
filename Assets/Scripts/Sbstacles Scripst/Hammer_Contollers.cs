
using UnityEngine;

public class Hammer_Contollers : MonoBehaviour
{
   public Rigidbody hummer;
   public bool direction;
   public float speed = 20;
   public float duration;
             void FixedUpdate()
        {
            Quaternion deltaRotation = Quaternion.Euler(Vector3.forward * (direction == true ? -speed : speed) * Time.fixedDeltaTime);
            hummer.MoveRotation(hummer.rotation * deltaRotation);
        }
}
