﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            AudioManager.instance.StopMusic();
            SceneManager.LoadScene("CreditsScene");
        }
    }
}
