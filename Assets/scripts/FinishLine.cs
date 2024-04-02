using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
  [SerializeField] float delayTime = 1f;
  [SerializeField] ParticleSystem finishedEffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
          finishedEffect.Play(finishedEffect);
          Invoke("reloadScene", delayTime);
          GetComponent<AudioSource>().Play();
        }
    }
    void reloadScene() {
       SceneManager.LoadScene(0);
    }
}
