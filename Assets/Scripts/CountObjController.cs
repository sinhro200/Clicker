using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountObjController : MonoBehaviour
{
    [SerializeField]
    private int max_count = 20;
    
    private int curr_count;

    private void Start()
    {
        curr_count = 0;
    }

    public bool can_add()
    {
        return (curr_count < max_count);
    }
    public void remove(int cnt = 1)
    {
        curr_count -= cnt;
    }
    public void add(int cnt = 1)
    {
        curr_count += cnt;
    }
}
