using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrumpWalking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target_obj;
    static Animator anim;
    float timer = 4.0f;


    public GameObject firePoint;
    public List<GameObject> vfx = new List<GameObject>();
    private GameObject effectToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {


        timer -= Time.deltaTime;
        //if (Vector3.Distance(target_obj.transform.position, this.transform.position) < 80){
            anim.SetBool("isWalking", true);
            //anim.SetBool("toAttack", false);
            anim.SetBool("toAttack", false);
            agent.SetDestination(target_obj.transform.position);
            if(Vector3.Distance(target_obj.transform.position, this.transform.position) < 100)
            {
                //anim.SetBool("toAttack", true);

                if (timer <= 0)
                {
                    //Debug.Log("fire!!!");
                    anim.SetBool("toAttack", true);
                anim.SetBool("isWalking", false);
                SpawnVFX();
                    timer = 4.0f;
                }
            
                anim.SetBool("isWalking", false);
                anim.SetBool("toAttack", false);
                agent.SetDestination(this.transform.position);
                agent.transform.LookAt(target_obj.transform.position);
            }

        //}
        /*else{
            agent.SetDestination(this.transform.position);
            //anim.SetBool("toAttack", false);
            anim.ResetTrigger("Attack");
            anim.SetBool("isWalking", false);
           
        }*/

    }

    void SpawnVFX()
    {
        GameObject efx;
        if (firePoint != null)
        {
            efx = Instantiate(effectToSpawn, firePoint.transform.position, Quaternion.identity);

            efx.transform.LookAt(GameObject.Find("RPG_Boy").transform);

        }
        else
        {
            Debug.Log("No fire point");
        }
    }
}
