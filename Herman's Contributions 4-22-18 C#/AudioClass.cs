using System;
using UnityEngine;
using System.Collections; 

namespace AssemblyCSharp
{
	public class AudioClass : MonoBehaviour {

		public AudioSource SoundFiles;	
		public AudioSource MusicFiles;	/// Persistently played background audio throughout the game.

		public AudioClip dropSound;	/// Specific audio clips played when requirements are met.
		public AudioClip LineClearing;
		public AudioClip GameMusic;
		public AudioClip WinTheme;
		public AudioClip LoseTheme;
		public AudioClip Interaction;



		public void StartWinTheme ()	///Specific audio clips
		{
			StopGameMusic ();
			soundSource.clip = WinTheme;
			soundSource.Play ();
		}
		public void StartLoseTheme ()
		{
			StopGameMusic ();
			soundSource.clip = LoseTheme;
			soundSOurce.Play (); 
		}
		public void StartInteractionSound()
		{
			soundSOurce.clip = Interaction;
			soundSource.Play (); 
		}
		public void StartLineClearingSound()
		{
			soundSource.clip = LineClearing;
			soundSource.Play ();
		}
		public void StartdropSound()
		{
			soundSource.clip = dropSound;
			soundSOurce.Play ();
		}
		public void StartInGameMusic()	///Persistent Music
		{
			musicSource.clip = GameMusic;
			musicSOurce.Play ();
		}
		public void Mute()
		{
			musicSource ();
		}
		public void AdjustSoundFX(int value)	///Volume Adjustment methods
		{
			int temp = value + soundSource.volume;
			if (temp < 0 || temp > 1)
				return;
			else
				soundSource.volume += value;
		}
		public void AdjustMusic(int value)
		{
			int temp = value + musicSource.volume;
			if (temp < 0 || temp > 1)
				return;
			else
				musicSource.volume += value;
		}
	}
}

