using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController2 : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] bgList;

    public void OnToggleChange(bool t)
    {
        audioSource.mute = t;
        cancelFocus();
    }

    public void OnDropdownChange(int index)
    {
        if (index == 1)
        {
            audioSource.clip = bgList[0];
            audioSource.Play();
            cancelFocus();
        }
        else
        {
            audioSource.clip = bgList[0];
            audioSource.volume = 0;
        }
    }

    public void OnSliderChange(float value)
    {
        audioSource.volume = value;
    }

    void cancelFocus()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
}