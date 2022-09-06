using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Finis_Controllers : MonoBehaviour
{
    public GameObject finishPlatform;
   
   private void OnTriggerEnter(Collider col)
   {
    if(col.gameObject.CompareTag("Player"))
    {
       finishPlatform.transform.DOLocalMoveX(1,2);
    }
   }
}
