using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReachTheGate : MonoBehaviour
{
    public Canvas myCanvas;
    public Image hpBar;
    // Start is called before the first frame update
    void Start()
    {
        myCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && hpBar.fillAmount>0)
        {
            myCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }
}
