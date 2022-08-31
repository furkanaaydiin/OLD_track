using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Conrollers : MonoBehaviour
{
public Animator animator;
     [SerializeField] private Joystick joystick;
     private bool isDead = false;
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
            
        }
    }
    private IEnumerator LoadScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
    
        

}
