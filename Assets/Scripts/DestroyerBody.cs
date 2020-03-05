using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBody : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        string s = "trigger exit";
        GameObject go = collision.gameObject;
        if (go.CompareTag("DestroyableObject"))
        {
            s+="\n-----with DestroyableObject";
            var cubeController = go.GetComponent<CubeController>();
            if (cubeController != null)
            {
                cubeController.destroy();
            }
        }
        Debug.Log(s);
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger enter");
        GameObject go = collision.gameObject;
        if (go.CompareTag("DestroyableObject"))
        {
            Debug.Log("-----with DestroyableObject");
            var cubeController = go.GetComponent<CubeController>();
            if (cubeController != null)
            {
                cubeController.destroy();
            }
        }
    }*/

}
    


