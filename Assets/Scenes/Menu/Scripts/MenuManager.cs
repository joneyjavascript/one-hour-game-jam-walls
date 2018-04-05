using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    private void Start()
    {       
        AudioManager.instance.Play("background");
    }

    public void StartGame()
    {
        GotoScene("GameScene");
    }

    public void SeeCredits()
    {
        GotoScene("CreditsScene");
    }
    
    public void GotoScene(string nestSceneName) {
        AudioManager.instance.StopMusic();
        SceneManager.LoadScene(nestSceneName);
    }

}
