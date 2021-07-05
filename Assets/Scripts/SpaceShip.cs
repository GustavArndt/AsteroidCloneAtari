using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private float timer ;

    void Start()
    {
        timer = 0 ;    
    }

    void Update()
    {
        Controller() ;
        print(timer) ;
        
    }

    void Controller(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            timer += Time.deltaTime ;
            if(timer >= 0.1f){// It was set a timer, otherwise the ship would rotate too fast.
                transform.eulerAngles -= new Vector3(0,0,-22.5f) ;
                timer = 0 ;
            }
            
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            timer += Time.deltaTime ;
            if(timer >= 0.1f){
                transform.eulerAngles -= new Vector3(0,0,22.5f) ;
                timer = 0 ;
            }
            
        }
    }
}
