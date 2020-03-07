using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCatcherScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse down");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);

            if (hit.collider != null && hit.transform.CompareTag("DestroyableObject"))
                hit.transform.gameObject.GetComponent<Destroyable>().destroy();
        }
    }

    private void test3()
    {
        if (Input.GetMouseButtonDown(0) )
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("trying Physics.Raycast");
            //Debug.DrawRay(ray.origin,ray.direction);
            if (Physics.Raycast(ray,out hit))
            {
                Debug.Log("hit smth (" + hit.collider.tag + ")");
                if (hit.collider.tag == "destroyableObject")
                {
                    Debug.Log("----it was destroyableObject");
                    hit.collider.gameObject.GetComponent<Destroyable>().destroy();
                }
            }
        }
    }
    private void test1()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);

        if (hit.collider != null )
            Debug.Log("Dot Hit : " + hit.transform.tag);
    }

    private void test2()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("mouse position: " + Input.mousePosition.x + " " + Input.mousePosition.y);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("hit smth (" + hit.collider.tag + ")");
            if (hit.collider.tag == "destroyableObject")
            {
                Debug.Log("----it was destroyableObject");
                //hit.collider.gameObject now refers to the 
                //cube under the mouse cursor if present
                hit.collider.gameObject.GetComponent<Destroyable>().destroy();
            }
        }
    }
}
