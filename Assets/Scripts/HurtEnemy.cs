using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    private int Life = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //Destroy(col.gameObject);
            Life -= 1;
            Debug.Log("hurt");
            if (Life == 0)
            {
                Destroy(col.gameObject);
                Life = 12;
                
            }

        }
    }
}
