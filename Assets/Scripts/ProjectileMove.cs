using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed;
    public float fireRate;
    public GameObject Hit;
    public AudioSource explosion;
    // Start is called before the first frame update
    void Start()
    {
        explosion.volume = 0;
    }

    // Update is called once per frame
    void Update()
    { 
            if (speed != 0)
            {
                transform.position += transform.forward * (speed * Time.deltaTime);
            }
            else
            {
                Debug.Log("No speed");
            }


    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Obstacles")
        {
            GameObject efx;
            if (Hit != null)
            {
                efx = Instantiate(Hit,this.transform.position, Quaternion.identity);
                efx.transform.LookAt(GameObject.Find("RPG_Boy").transform.position);
                explosion.volume = 1;
                explosion.Play();
            }
            speed = 0;
            Destroy(gameObject);
        }
            
    }
}
