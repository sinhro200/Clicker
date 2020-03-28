using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLogic : MonoBehaviour
{
    public int BeginScore = 20; 
    public int IncScoreOnClick = 2;
    public int IncScoreOnOut = -2;
    public int CoefficOnMultClick = 2;
    

    public int UpdateScore(int score,DestroyType dt,int multCount = 1)
    {
        switch (dt)
        {
            case DestroyType.OnClick:
                return score += multCount == 1 ? IncScoreOnClick : IncScoreOnClick * multCount * CoefficOnMultClick;
            case DestroyType.OnOut:
                return score += IncScoreOnOut * multCount;
            default:
                return score;
        }
    }

    public enum DestroyType{
        OnClick,
        OnOut
    }
   
}
