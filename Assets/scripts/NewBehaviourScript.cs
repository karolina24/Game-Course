using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float torqueAmountLeft = 1f;
    [SerializeField] float torqueAmountRight = -1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
           }
    void Update()
        {
            if (canMove){
                turn();
                respondToBoost();
            }
        }

        public void DisableControl(){
            canMove = false;
        }
    void turn(){
    if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmountLeft);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(torqueAmountRight);
        }
    }
    void respondToBoost(){
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else 
        {
             surfaceEffector2D.speed = baseSpeed;
        }
    }
   
    
    }
