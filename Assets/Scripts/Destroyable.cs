using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{

    public void destroy()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
        
    }
}
