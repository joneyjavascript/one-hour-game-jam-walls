using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void StartGame()
    {
        GotoScene("GameScene");
    }

    public void SeeCredits()
    {
        GotoScene("CreditsScene");
    }
    
    public void GotoScene(string nestSceneName) {
        SceneManager.LoadScene(nestSceneName);
    }

}
