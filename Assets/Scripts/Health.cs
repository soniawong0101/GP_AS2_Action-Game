using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Canvas myCanvas;
    public Image hpBar;
    public float MaxHp = 100;
    private float nowHP;

    void Start()
    {
        nowHP = MaxHp;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //Debug.Log("yay");
            nowHP -= 4;
            updateHPBar();
        }
        if (col.gameObject.tag == "Fireball")
        {
            //Debug.Log("yay");
            nowHP -= 10;
            updateHPBar();
        }
        if (nowHP <= 0)
        {
            myCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }

    /*void Update () {
      nowHP -= Time.deltaTime *5;
      if (nowHP <0)
      { 
        nowHP = MaxHp;
      }

      updateHPBar();
    }*/
    void updateHPBar()
    {
        hpBar.fillAmount = nowHP / MaxHp;
    }
}