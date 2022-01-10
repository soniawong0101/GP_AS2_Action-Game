using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    Canvas gameRules;
    Canvas settings;
    Canvas hp;
    AudioSource explosion;

    private void Start()
    {
        gameRules = GameObject.Find("Rules").GetComponent<Canvas>();
        gameRules.enabled = false;
        settings = GameObject.Find("SetupPage").GetComponent<Canvas>();
        settings.enabled = false;
        hp = GameObject.Find("HealthBarCanvas").GetComponent<Canvas>();
        hp.enabled = false;
        explosion = GameObject.Find("ExplosionSE").GetComponent<AudioSource>();
        explosion.enabled = false;
    }
    public void NewGameBtn(string gameScene)
    {
        SceneManager.LoadScene(gameScene);
        hp.enabled = true;
        explosion.enabled = true;
    }
    public void ExitGameBtn()
    {
        Debug.Log("exit");
        Application.Quit();
        
    }

    public void ShowGameRules()
    {
        Debug.Log("rules");
        gameRules.enabled = true;
    }
    public void HideGameRules()
    {
        gameRules.enabled = false;
    }
    public void ShowSetupPage()
    {
        settings.enabled = true;
    }
    public void HideSetupPage()
    {
        settings.enabled = false;
    }
}
