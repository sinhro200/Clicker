using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCatcherScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("mouse down");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("mouse position: " + Input.mousePosition.x + " " + Input.mousePosition.y);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("hit smth");
            if (hit.collider.tag == "destroyableObject")
            {
                Debug.Log("----it was destroyableObject");
                //hit.collider.gameObject now refers to the 
                //cube under the mouse cursor if present
                hit.collider.gameObject.GetComponent<CubeController>().destroy();
            }
        }
    }

    private void test3()
    {

    }
    private void test1()
    {
        Vector2 CurMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void test2()
    {
       
    }
}
