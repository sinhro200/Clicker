using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyCore : MonoBehaviour
{
    [SerializeField]
    private float cooldown_mult = 1.1f;
    [SerializeField]
    private float velocity_mult = 1.1f;
    
    public float getVelocity(float beginVelocity,int level)
    {
        return beginVelocity*Mathf.Pow(velocity_mult, level);
    }
    public float getCooldown(float beginCooldown, int level)
    {
        return beginCooldown / Mathf.Pow(cooldown_mult, level);
    }
}
