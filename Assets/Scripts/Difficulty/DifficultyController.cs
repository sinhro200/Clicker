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

    private void Start()
    {
        Debug.Log("Level updated to " + _prevLevel + " \n Recharge [" + 
            DifficultyCore.CalcRecharge(Spawner.BeginRecharge, _prevLevel) + 
            "]  Velocity [" + DifficultyCore.CalcVelocity(Spawner.BeginVelocity, _prevLevel) + "]");
    }
    void FixedUpdate()
    {
        int level = CalcLevel(ScoreController.CurrScore());
        if (level != _prevLevel)
        {
            float recharge = DifficultyCore.CalcRecharge(Spawner.BeginRecharge, level);
            float vel = DifficultyCore.CalcVelocity(Spawner.BeginVelocity, level);
            Spawner.UpdateRecharge(recharge);
            Spawner.UpdateVelocity(vel);
            _prevLevel = level;

            Debug.Log("Level updated to " + level + " \n Recharge [" + recharge + "]  Velocity [" + vel + "]");
        }
    }

    private int CalcLevel(int score)
    {
        return score / PointsByLevel + 1;
    }
}
