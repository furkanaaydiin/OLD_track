using UnityEngine;
using DG.Tweening;

public class turning_Controllers : MonoBehaviour
{
    public GameObject turning;
    public float speed;
    public bool direction;
     private void Update()
    {
        if(direction == false)
        {
            turning.transform.DORotate( new Vector3 (0,speed * Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
        else
        {
             turning.transform.DORotate( new Vector3 (0,-1*speed * Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
    }
}
