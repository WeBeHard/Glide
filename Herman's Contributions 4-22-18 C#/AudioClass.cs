using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClass : MonoBehaviour {

    public AudioSource SoundFiles;
    public AudioSource MusicFiles;  /// Persistently played background audio throughout the game.

    public AudioSource musicSource;
    public AudioSource soundSource;

    public AudioClip dropSound; /// Specific audio clips played when requirements are met.
    public AudioClip LineClearing;
    public AudioClip GameMusic;
    public AudioClip WinTheme;
    public AudioClip LoseTheme;
    public AudioClip Interaction;



    public void StartWinTheme() ///Specific audio clips
    {
        Mute();
        soundSource.clip = WinTheme;
        soundSource.Play();
    }
    public void StartLoseTheme()
    {
        Mute();
        soundSource.clip = LoseTheme;
        soundSource.Play();
    }
    public void StartInteractionSound()
    {
        soundSource.clip = Interaction;
        soundSource.Play();
    }
    public void StartLineClearingSound()
    {
        soundSource.clip = LineClearing;
    }
        public void StartdropSound()
        {
            soundSource.clip = dropSound;
            soundSource.Play();
        }
        public void StartInGameMusic()	///Persistent Music
		{
            musicSource.clip = GameMusic;
            musicSource.Play();
        }
        public void Mute()
        {
            musicSource.Stop();
        }
        public void AdjustSoundFX(float value)	///Volume Adjustment methods
		{
            float temp = value + soundSource.volume;
            if (temp < 0 || temp > 1)
                return;
            else
                soundSource.volume += value;
        }
        public void AdjustMusic(float value)
        {
            float temp = value + musicSource.volume;
            if (temp < 0 || temp > 1)
                return;
            else
                musicSource.volume += value;
        }
    }
