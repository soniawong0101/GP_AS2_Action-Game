using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject firePoint;
    public List<GameObject> vfx = new List<GameObject>();
    private GameObject effectToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnVFX();
        }
    }
    void SpawnVFX()
    {
        GameObject efx;
        if (firePoint != null)
        {
            efx = Instantiate(effectToSpawn, firePoint.transform.position, Quaternion.identity);

            efx.transform.LookAt(GameObject.Find("RPG_Boy").transform.position);

        }
        else
        {
            Debug.Log("No fire point");
        }
    }
}
