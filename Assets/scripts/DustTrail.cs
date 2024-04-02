using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;
  
     
        
    void OnCollisionEnter2D(Collision2D other) {
      
            dustTrail.Play(dustTrail);
        
    }
      void OnCollisionExit2D(Collision2D other) {
            dustTrail.Stop(dustTrail);
        }
        
    
 
}
