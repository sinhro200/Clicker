using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    [SerializeField]
    private Spawner spawner;
    [SerializeField]
    private ScoreController scco;
    [SerializeField]
    private int points_by_level = 50;
    [SerializeField]
    private DifficultyCore difficultyCore;

    private int prevLevel = 1;
    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        int level = getLevel(scco.currScore());
        if (level <= 0)
        {
            Debug.Log("level is " + level);
        }
        else if (level != prevLevel)
        {

            spawner.updateCooldown(difficultyCore.getCooldown(spawner.begin_cooldown,level));
            spawner.updateVelocity(difficultyCore.getVelocity(spawner.begin_velocity, level));
            prevLevel = level;
        }
    }

    private int getLevel(int score)
    {
        return score / points_by_level + 1;
    }
}
