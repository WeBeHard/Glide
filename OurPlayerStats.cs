using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OurPlayerStats : ScriptableObject {
    public int CumulativeScore = 0;
    public int TotalGamesPlayed = 0;

    public int ClassicHiScore = 0;
    public int ClassicTotalScore = 0;
    public double ClassicAvgScore = 0;
    public int ClassicTotalGamesPlayed = 0;

    public int TimeAttackHiScore = 0;
    public int TimeAttackTotalScore = 0;
    public double TimeAttackAvgScore = 0;
    public int TimeAttackTotalGamesPlayed = 0;

    public int PowersHiScore = 0;
    public int PowersTotalScore = 0;
    public double PowersAvgScore = 0;
    public int PowersTotalGamesPlayed = 0;

    void UpdateStats(int currentMode, int currentGameScore)
    {
        CumulativeScore += gameScore;
        TotalGamesPlayed++;

        if (currentMode = 1) {
            UpdateClassic(currentGameScore);
        }
        else if (currentMode = 2) {
            UpdateTimeAttack(currentGameScore);
        }
        else if (currentMode = 3) {
            UpdatePowers(currentGameScore);
        }
    }

    void UpdateClassic(int score)
    {
        if (ClassicHiScore < score)
        {
            ClassicHiScore = score;
        }
        ClassicTotalScore += score;
        ClassicTotalGamesPlayed++;
        ClassicAvgScore = ClassicTotalScore / ClassicTotalGamesPlayed;
    }

    void UpdateTimeAttack(int score)
    {
        if (TimeAttackHiScore < score)
        {
            TimeAttackHiScore = score;
        }
        TimeAttackTotalScore += score;
        TimeAttackTotalGamesPlayed++;
        TimeAttackAvgScore = TimeAttackTotalScore / TimeAttackTotalGamesPlayed;
    }

    void UpdatePowers(int score)
    {
        if (PowersHiScore < score)
        {
            PowersHiScore = score;
        }
        PowersTotalScore += score;
        PowersTotalGamesPlayed++;
        PowersAvgScore = PowersTotalScore / PowersTotalGamesPlayed++;
    }

    void WipeStats()
    {
        CumulativeScore = 0;
        TotalGamesPlayed = 0;

        ClassicHiScore = 0;
        ClassicTotalScore = 0;
        ClassicAvgScore = 0;
        ClassicTotalGamesPlayed = 0;

        TimeAttackHiScore = 0;
        TimeAttackTotalScore = 0;
        TimeAttackAvgScore = 0;
        TimeAttackTotalGamesPlayed = 0;

        PowersHiScore = 0;
        PowersTotalScore = 0;
        PowersAvgScore = 0;
        PowersTotalGamesPlayed = 0;
    }
}
