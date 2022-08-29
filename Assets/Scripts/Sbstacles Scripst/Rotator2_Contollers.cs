using UnityEngine;
using DG.Tweening;

public class Rotator2_Contollers : MonoBehaviour
{
    public GameObject rotator2;
    public float speed;
    public bool direction;
    private void Update()
    {
        if(direction == false)
        {
            rotator2.transform.DORotate(new Vector3 (0,speed*Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
        else
        {
            rotator2.transform.DORotate(new Vector3 (0,-1*speed*Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
    }
}
