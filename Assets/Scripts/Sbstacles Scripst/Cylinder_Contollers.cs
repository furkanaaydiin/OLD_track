using UnityEngine;
using DG.Tweening;

public class Cylinder_Contollers : MonoBehaviour
{
    public GameObject cylinder;
    public float speed;
    public bool direction;
    private void Update()
    {
        if(direction == false)
        {
           cylinder.transform.DORotate( new Vector3 (0,0,speed*Time.deltaTime),-1,RotateMode.WorldAxisAdd);
        }
        else
        {
            cylinder.transform.DORotate( new Vector3 (0,0, -1 * speed*Time.deltaTime),-1,RotateMode.WorldAxisAdd);
        }
    }
}
