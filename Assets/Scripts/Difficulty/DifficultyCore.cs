using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyCore : MonoBehaviour
{
    public float RechargeMult = 1.1f;
    public float VelocityMult = 1.1f;
    
    public float CalcVelocity(float velocity,int level)
    {
        return velocity*Mathf.Pow(VelocityMult, level);
    }
    public float CalcRecharge(float recharge, int level)
    {
        return recharge / Mathf.Pow(RechargeMult, level);
    }
}
