using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    
    void Start()
    {
        
    }
    /*void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Weapon" ){
            Debug.Log("Hi");
            Destroy(gameObject);
        }
    }*/
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Weapon"){
            if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Hi");
            Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
