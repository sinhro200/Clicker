using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBody : MonoBehaviour
{

    public Direction Dir;

    private Vector2 _leftTop;
    private Vector2 _rightBot;


    void Start()
    {
        Vector2 center = gameObject.transform.position;
        Vector3 transform = gameObject.transform.localScale;
        _leftTop = new Vector2(center.x - transform.x/2, center.y + transform.y / 2);
        _rightBot = new Vector2(center.x + transform.x / 2, center.y - transform.y / 2);
    }

    public void spawn(GameObject gameObj,float velocity)
    {
        if (gameObj == null)
            return;
        
        Vector2 pos = GetRandomPositionInside();
        
        GameObject newInstance = Instantiate(gameObj, pos, Quaternion.identity);

        var vel = GetNormVelocity() * velocity;
        newInstance.GetComponent<Rigidbody2D>().velocity = vel;
    }

    private Vector2 GetNormVelocity()
    {
        switch (Dir)
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

    private Vector2 GetRandomPositionInside()
    {
        return new Vector2(Random.Range(_leftTop.x, _rightBot.x), Random.Range(_leftTop.y, _rightBot.y));
    }
}
