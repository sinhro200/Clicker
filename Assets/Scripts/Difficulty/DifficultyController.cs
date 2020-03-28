using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    public Spawner Spawner;
    public ScoreController ScoreController;
    public int PointsByLevel = 50;
    public DifficultyCore DifficultyCore;

    private int _prevLevel = 1;

    void FixedUpdate()
    {
        int level = CalcLevel(ScoreController.CurrScore());
        if (level != _prevLevel)
        {
            Spawner.UpdateRecharge(DifficultyCore.CalcRecharge(Spawner.BeginRecharge,level));
            Spawner.UpdateVelocity(DifficultyCore.CalcVelocity(Spawner.BeginVelocity, level));
            _prevLevel = level;
        }
    }

    private int CalcLevel(int score)
    {
        return score / PointsByLevel + 1;
    }
}
