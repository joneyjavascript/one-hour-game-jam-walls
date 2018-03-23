using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour {

    public void BackToMenu()
    {
        GotoScene("MenuScene");
    }
    
    public void GotoScene(string nestSceneName) {
        SceneManager.LoadScene(nestSceneName);
    }

}
