using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountObjController : MonoBehaviour
{

    public int MaxCount = 20;
    
    private int _currCount;

    private void Start()
    {
        _currCount = 0;
    }

    public bool CanAdd()
    {
        return (_currCount < MaxCount);
    }
    public void DecreaseCount(int cnt = 1)
    {
        _currCount -= cnt;
    }
    public void IncreaseCount(int cnt = 1)
    {
        _currCount += cnt;
    }
}
