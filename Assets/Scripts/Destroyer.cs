using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private CountObjController coco;
    [SerializeField]
    private ScoreController scco;
    void Start()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.activeSelf)
            return;
        GameObject go = collision.gameObject;
        if (go.CompareTag("DestroyableObject"))
        {
            var cubeController = go.GetComponent<Destroyable>();
            if (cubeController != null)
            {
                cubeController.destroy();
                coco.remove();
                scco.destroyOnOut();
            }
        }
    }
    

}
    


