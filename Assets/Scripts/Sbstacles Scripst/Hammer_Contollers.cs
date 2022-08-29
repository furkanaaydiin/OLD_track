using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hammer_Contollers : MonoBehaviour
{
   public GameObject hummer;
   public float duration;
    private void Awake()
    {
        hummer.transform.DOLocalRotate(Vector3.forward * 50f,duration,0).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
