using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Resitance_Contollers : MonoBehaviour
{

    public GameObject residance;
    public float duration;
    private bool _direction;
    private Transform newtrasform;
    
    private void Awake()
    {
       this.gameObject.transform.localPosition =  Vector3.right *(_direction ? -3 : 3);
       transform.DOLocalMoveX (_direction ? 3 : -3, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}

