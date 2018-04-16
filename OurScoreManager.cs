using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurScoreManager : MonoBehaviour {

	///Boolean for detecting what gamemode is being played needed here
		public int CurrentScore = 0;
        public int GameModeHiScore = 0;

    private void Awake()
    {
        if (Managers.Game.stats.highScore != 0)
        {
            GameModeHiScore = Managers.Game.stats.highScore;
            Managers.UI.inGameUI.UpdateScoreUI();

        }
        else
        {
            GameModeHiScore = 0;
            Managers.UI.inGameUI.UpdateScoreUI();
        }
    }
    
    public void UpdateScore(int UpdateValue)
    {
        CurrentScore += UpdateValue;
        CheckGameModeHiScore(); ////Find where this method is defined.
        Managers.UI.inGameUI.UpdateScoreUI();
        Managers.Game.stats.totalScore += UpdateValue;
    }
    public void CheckGameModeHiScore()
    {
        if (GameModeHiScore < CurrentScore)
        {
            GameModeHiScore = CurrentScore;
        }
    }
        public void WipeScore()
    {
            CurrentScore = 0;
        GameModeHiScore = Managers.Game.stats.highScore;
        Managers.UI.inGameUI.UpdateScoreUI();
    }
}

