using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public CountObjController CountObjController;
    public ScoreController ScoreController;

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
                CountObjController.Increase();
                ScoreController.DestroyOnOut();
            }
        }
    }
    

}
    


