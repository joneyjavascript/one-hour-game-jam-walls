using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System;

public class AudioManager : MonoBehaviour {

    public SoundCollection soundCollection;

    public static AudioManager instance;

    private Sound musicPlaying;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        foreach (Sound s in soundCollection.sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }        
    }

    public void Play(string name) {
        
        Sound s = Array.Find(soundCollection.sounds, sound => sound.name == name);
        
        if (s == null) {
            Debug.LogWarning("Try to play sound that not exists. sound name: " + name);
            return;
        }

        if (s.randomPitch)
        {
            s.source.pitch = UnityEngine.Random.Range(s.randomMin, s.randomMax);
        }

        if (s.loop) {
            if (HasMusicPlaying())
            {
                StopMusic();
            }

            Debug.Log("Stored Music " + s.name);
            musicPlaying = s;
        }

        Debug.Log("Play Sound " + s.name + ", Loop: " + s.loop);
        s.source.Play();
    }

    public void StopMusic() {
        if (HasMusicPlaying())
        {
            Debug.Log("Stop Music " + musicPlaying.name);
            musicPlaying.source.Stop();
        }
    }

    bool HasMusicPlaying()
    {
        return musicPlaying != null;
    }
    
    // Use this for initialization
    void Start () {        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
