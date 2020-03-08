using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCatcherScript : MonoBehaviour
{
    [SerializeField]
    private ScoreController scoreController;
    [SerializeField]
    private CountObjController coco;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            test4_works();
        }
    }

    public void test4_works()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll(ray);

        int cnt_to_destroy = 0;
        foreach (RaycastHit2D hit in hits)
        {
            //Debug.Log(hit.collider.tag);

            if (hit.collider.CompareTag("DestroyableObject"))
            {
                cnt_to_destroy++;
                hit.collider.gameObject.GetComponent<Destroyable>().destroy();
            }
            else 
            {
                scoreController.missedClick();
            }
        }
        if (cnt_to_destroy != 0)
        {
            scoreController.destroyOnClick(cnt_to_destroy);
            coco.remove(cnt_to_destroy);
        }

    }
    public void ScreenMouseRay()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;

        Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(v);
        

        if (col.Length > 0)
        {
            foreach (Collider2D c in col)
            {
                //Debug.Log("Collided with: " + c.collider2D.gameObject.name);
                var targetPos = c.gameObject.transform.position;
                Debug.Log(c.gameObject.tag);

            }
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
                if (hit.collider.CompareTag("DestroyableObject"))
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
