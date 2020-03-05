using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBody : MonoBehaviour
{
    [SerializeField]
    private Direction dir;
    [SerializeField]
    private GameObject obj;

    private Vector2 leftTop;
    private Vector2 rightBot;


    void Start()
    {
        Vector2 center = gameObject.transform.position;
        //Debug.Log("Center of Gobj = "+center.x.ToString() + " " + center.y.ToString());
        Vector3 transform = gameObject.transform.localScale;
        leftTop = new Vector2(center.x - transform.x/2, center.y + transform.y / 2);
        rightBot = new Vector2(center.x + transform.x / 2, center.y - transform.y / 2);

        obj = obj == null ? new GameObject() : obj;
    }

    public void spawn(float velocity)
    {
        Vector2 pos = getRandomPosition();

        GameObject newInstance = Instantiate(obj, pos, Quaternion.identity);
        var vel = getNormVelocity()*velocity;
        newInstance.GetComponent<Rigidbody2D>().velocity = vel;
    }

    private Vector2 getNormVelocity()
    {
        switch (dir)
        {
            case Direction.Down:
                return new Vector2(0, -1);
            case Direction.Up:
                return new Vector2(0, 1);
            case Direction.Right:
                return new Vector2(1, 0);
            case Direction.Left:
                return new Vector2(-1, 0);
        }
        return new Vector2(0, 0);
    }

    private Vector2 getRandomPosition()
    {
        return new Vector2(Random.Range(leftTop.x, rightBot.x), Random.Range(leftTop.y, rightBot.y));
    }
}
