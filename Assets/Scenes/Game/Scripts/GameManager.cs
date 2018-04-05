﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    private float _oldTimeScale;
    private bool paused = false;

    private void Start()
    {     
        AudioManager.instance.Play("background");
    }

    public void PauseGame()
    {
        if (paused)
        {
            throw new UnityException("Game is paused, not pause again.");
        }

        _oldTimeScale = Time.timeScale;
        Time.timeScale = 0;
        paused = true;        
    }

    public void ResumeGame()
    {
        if (!paused)
        {
            throw new UnityException("Game is not paused, can not resume it.");
        }

        Time.timeScale = _oldTimeScale;
        paused = false;
       
    }

    public void BackToMenu()
    {
        GotoScene("MenuScene");
    }
    
    public void GotoScene(string nestSceneName) {
        AudioManager.instance.StopMusic();
        SceneManager.LoadScene(nestSceneName);
    }

}
