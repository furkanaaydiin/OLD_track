using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Player_Conrollers : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private Joystick joystick;
    private bool isDead = false;
     public GameObject cameraa;
     public GameObject player;
    
     public float duration;
     public float endValue;
     

     
    
    
    
    
    
     

      

     private void OnTriggerEnter(Collider col)
    {
        if(isDead) return;
       
         if(col.gameObject.CompareTag("resistance"))
        {
             isDead = true;
            joystick.Clear();
           animator.SetTrigger("IsDead");
            StartCoroutine(LoadScene(3));

        }

        if(col.gameObject.CompareTag("Finish"))
        {
            
            joystick.Clear();
            animator.SetTrigger("IsDance");
            StartCoroutine(LoadScene(5));
            cameraa.SetActive(true);
            player.transform.DOLocalMoveZ(endValue,duration)
            .OnComplete(()=> {
                player.transform.DORotate(new Vector3(0,180,0),1);
                player.transform.DOScale(Vector3.one* 0.3f ,1);
                

             });
           
   
        }
    }


   
    private IEnumerator LoadScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
    
        

}
