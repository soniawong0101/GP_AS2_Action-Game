using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardPlayer : MonoBehaviour
{
    public Camera cam;
    public float maximumLength;
    private Ray rayMouse;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotation;
    public GameObject aim;
    // Start is called before the first frame update
    void Start()
    {
        if (cam != null)
        {
            RaycastHit hit;
            var MousePos = aim.transform.position;
            rayMouse = cam.ScreenPointToRay(MousePos);
            if(Physics.Raycast(rayMouse.origin, rayMouse.direction, out hit, maximumLength))
            {
                RotateToPlayerDirection(gameObject, hit.point);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RotateToPlayerDirection(GameObject obj, Vector3 destination)
    {
        direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }

    public Quaternion GetRotation()
    {
        return rotation;
    }
}
