using UnityEngine;
using DG.Tweening;

public class Cylinder_Contollers : MonoBehaviour
{
    public Rigidbody cylinder;
    public float duration;
    public bool direction;

    public float force = 20;


            void FixedUpdate()
        {
            Quaternion deltaRotation = Quaternion.Euler(Vector3.up * (direction == true ? -20 : 20) * Time.fixedDeltaTime);
            cylinder.MoveRotation(cylinder.rotation * deltaRotation);
        }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce((direction == true ? Vector3.left : Vector3.right)*force,ForceMode.Force);
        }
    }
}
