using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Resitance_Contollers : MonoBehaviour
{

    public Transform residance;
    public float duration;
    private bool _direction;
    public float goPos;
    
    
    private void Awake()
    {
        residance.localPosition = Vector3.zero;
        if(_direction == false)
        {
        residance.DOLocalMoveX(goPos,duration).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        }
        else
        {
        residance.DOLocalMoveX(-1 * goPos,duration).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        }

        
    }
}

