using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    Canvas Restart;

    private void Start()
    {
        
        Restart = GameObject.Find("RestartPage").GetComponent<Canvas>();
        Restart.enabled = false;
        //healthbar = GameObject.Find("HealthBarCanvas").GetComponent<Canvas>();
        //healthbar.enabled = false;
    }
    /*public void NewGameBtn(string gameScene)
    {
        SceneManager.LoadScene(gameScene);
    }*/
    public void ExitGameBtn()
    {
        Debug.Log("exit");
        Application.Quit();
    }
    public void RestartGame(string gameScene)
    {

        SceneManager.LoadScene(gameScene);
        Time.timeScale = 1;
        //healthbar.enabled = true;
        //Debug.Log("hihi");
    }

    /*public void ShowGameRules()
    {
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
    }*/
}
