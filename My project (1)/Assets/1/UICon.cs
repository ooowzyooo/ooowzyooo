using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UICon : MonoBehaviour
{
   

    public AudioSource au;
    private int nextScene;
    public void PlayAudio()
    {
        au.Play();
    }

    public void Next()
    {
        PlayAudio();
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene > 4)
            nextScene = 0;
        Invoke("ChangeScene", 0.5f);
    }
    public void Last()
    {
        PlayAudio();
        nextScene = SceneManager.GetActiveScene().buildIndex - 1;
        if (nextScene < 0)
            nextScene = 4;
        Invoke("ChangeScene", 0.5f);
    }
    public void ChanegeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
