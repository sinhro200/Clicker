using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void destroy()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
        
    }
}
