using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetecor : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
     [SerializeField] ParticleSystem finishedEffect;
     bool canMove = true;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && canMove){
            FindObjectOfType<NewBehaviourScript>().DisableControl();
            finishedEffect.Play(finishedEffect);
            GetComponent<AudioSource>().Play();
            Invoke("reloadScene", delayTime);
            }else{
                canMove = false;
            }    
            
          
        }
    

    void reloadScene() {
       SceneManager.LoadScene(0);
    }
}
