using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCatcherScript : MonoBehaviour
{
    [SerializeField]
    private ScoreController ScoreController;
    [SerializeField]
    private CountObjController CountObjControl;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ScreenClickEvent();
        }
    }

    private void ScreenClickEvent()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll(ray);

        int cntToDestroy = 0;
        foreach (RaycastHit2D hit in hits)
        {


            if (hit.collider.CompareTag("DestroyableObject"))
            {
                cntToDestroy++;
                hit.collider.gameObject.GetComponent<Destroyable>().destroy();
            }
        }
        if (cntToDestroy != 0)
        {
            ScoreController.DestroyOnClick(cntToDestroy);
            CountObjControl.Increase(cntToDestroy);
        }

    }
   
}
