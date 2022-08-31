
using UnityEngine;
using DG.Tweening;

public class Rotator_Controllers : MonoBehaviour
{
    public GameObject rotator;
    public float duraction;
    private void Awake()
    {
        rotator.transform.DOLocalRotate(Vector3.up*1,duraction,0).SetLoops(-1,LoopType.Yoyo);
    }
}
