using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLogic : MonoBehaviour
{
    [SerializeField] private int score_on_click = 2;
    [SerializeField] private int score_on_out = -4;
    [SerializeField] private int coeffic_on_mult_click = 2;
    [SerializeField] private int score_on_missed = -2;

    public int updateScore(int score,DestroyType dt,int multCount = 1)
    {
        switch (dt)
        {
            case DestroyType.OnClick:
                return score += multCount == 1 ? score_on_click : score_on_click * multCount * coeffic_on_mult_click;
            case DestroyType.OnOut:
                return score += score_on_out * multCount;
            case DestroyType.OnMissed:
                return score += score_on_missed * multCount;
            default:
                return score;
        }
    }

    public enum DestroyType{
        OnClick,
        OnOut,
        OnMissed
    }
   
}
