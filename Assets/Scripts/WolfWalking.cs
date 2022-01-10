using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WolfWalking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target_obj;
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target_obj.transform.position, this.transform.position) < 100)
        {
            //anim.SetBool("isWalking", true);
            agent.SetDestination(target_obj.transform.position);

        }
        else
        {
            agent.SetDestination(this.transform.position);
        }


        //agent.transform.rotation = Quaternion.LookRotation(agent.velocity.normalized);


        //if(Vector3.Distance(target_obj.transform.position, this.transform.position) < 30){
        //  anim.SetBool("toAttack", true);
        //agent.Stop();
        //}
        //else{
        //  agent.SetDestination(target_obj.transform.position);
        //anim.SetBool("toAttack", false);
        //agent.isStopped = true;
        //agent.ResetPath();
        //}
    }
}
