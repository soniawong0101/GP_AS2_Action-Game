using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Enemy"){
            if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Hi");
            Destroy(col.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
