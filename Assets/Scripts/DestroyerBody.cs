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
        GameObject go = collision.gameObject;
        if (go.CompareTag("DestroyableObject"))
        {
            var cubeController = go.GetComponent<Destroyable>();
            if (cubeController != null)
            {
                cubeController.destroy();
            }
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger enter");
        GameObject go = collision.gameObject;
        if (go.CompareTag("DestroyableObject"))
        {
            Debug.Log("-----with DestroyableObject");
            var cubeController = go.GetComponent<Destroyable>();
            if (cubeController != null)
            {
                cubeController.destroy();
            }
        }
    }*/

}
    


