using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : Monobehavior
{
    public int CurrentGameMode = 0;
    public int GameModeHiScore = 0;
    public int CurrentScore = 0;

    #region SCORE 

    // Game = game manager
    // stats = OurPlayerStats (replaced by Unity pref file)

        private void checkCurrentGameMode()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            if (sceneName == "ClassicMode")
            {
                GameModeHiScore = Managers.Game.stats.ClassicHiScore;
                CurrentGameMode = 1;
            }
            else if (sceneName == "TimeAttack")
            {
                GameModeHiScore = Managers.Game.stats.TimeAttackHiScore;
                CurrentGameMode = 2;
            }
            else if (sceneName == "PowersMode")
            {
                GameModeHiScore = Managers.Game.stats.PowersHiScore;
                CurrentGameMode = 3;
            }
            else
            {
                GameModeHiScore = 0;
            }
        }
        
        private void Awake()
        {
            checkCurrentGameMode();
            //Managers.UI.inGameUI.UpdateScoreUI(); // Dipslay score on UI if used
        }

        public void UpdateScore(int UpdateValue)
        {
            CurrentScore += UpdateValue;
            CheckGameModeHiScore();
            //Managers.UI.inGameUI.UpdateScoreUI(); // Dipslay score on UI if used
            Managers.Game.stats.CumulativeScore += UpdateValue;
        }

        public void CheckGameModeHiScore()
        {
            if (GameModeHiScore < CurrentScore)
            {
                GameModeHiScore = CurrentScore;
            }
        }
        
        void UpdateStats()
        {
            Managers.Game.stats.TotalGamesPlayed++;

            if (CurrentGameMode = 1)
            {
                if (GameModeHiScore <= CurrentScore)
                {
                    Managers.Game.stats.ClassicHiScore = CurrentScore;
                }
                Managers.Game.stats.ClassicTotalScore += CurrentScore;
                Managers.Game.stats.ClassicTotalGamesPlayed++;
                Managers.Game.stats.ClassicAvgScore =
               (Managers.Game.stats.ClassicTotalScore / Managers.Game.stats.ClassicTotalGamesPlayed);
            }
            else if (CurrentGameMode = 2)
            {
                if (GameModeHiScore <= CurrentScore)
                {
                    Managers.Game.stats.TimeAttackHiScore = CurrentScore;
                }
                Managers.Game.stats.TimeAttackTotalScore += CurrentScore;
                Managers.Game.stats.TimeAttackTotalGamesPlayed++;
                Managers.Game.stats.TimeAttackAvgScore =
               (Managers.Game.stats.TimeAttackTotalScore / Managers.Game.stats.TimeAttackTotalGamesPlayed);
            }
            else if (CurrentGameMode = 3)
            {
                if (GameModeHiScore <= CurrentScore)
                {
                    Managers.Game.stats.PowersHiScore = CurrentScore;
                }
                Managers.Game.stats.PowersTotalScore += CurrentScore;
                Managers.Game.stats.PowersTotalGamesPlayed++;
                Managers.Game.stats.PowersAvgScore =
               (Managers.Game.stats.PowersTotalScore/ Managers.Game.stats.PowersTotalGamesPlayed);
            }
        }

        public void ResetScore()
        {
            CurrentScore = 0;
            checkCurrentGameMode();
            //Managers.UI.inGameUI.UpdateScoreUI(); Update UI if used
        }

    #endregion SCORE
}
