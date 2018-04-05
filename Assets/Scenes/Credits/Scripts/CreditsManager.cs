using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour {


    private void Start()
    {
       
        AudioManager.instance.Play("background");
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
