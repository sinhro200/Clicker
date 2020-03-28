using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    public float begin_cooldown = 2;
    [SerializeField]
    public float begin_velocity = 10;
    [SerializeField]
    private GameObject spawn_object;
    [SerializeField]
    [InspectorName("Count controller")]
    private CountObjController coco;

    private float time;
    private float cooldown;
    private float velocity;

    SpawnerBody[] spawners;
    void Start()
    {
        spawners = getSpawnerBodies();
        time = 0;
        cooldown = begin_cooldown;
        velocity = begin_velocity;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > cooldown)
        {
            time -= cooldown;


            if (coco.can_add())
            {
                SpawnerBody sb = spawners[Random.Range(0, spawners.Length)];
                sb.spawn(spawn_object, velocity);
                coco.add();
            }
        }
    }

    private SpawnerBody[] getSpawnerBodies()
    {
        List<SpawnerBody> spawners = new List<SpawnerBody>();
        foreach (var item in gameObject.GetComponentsInChildren<SpawnerBody>())
        {
            if (item.CompareTag("SpawnerBody"))
            {
                spawners.Add(item);
            }
        }

        return spawners.ToArray();
    }

    public void updateCooldown(float cooldown)
    {
        this.cooldown = cooldown;
    }
    public void updateVelocity(float velocity)
    {
        Debug.Log(velocity);
        this.velocity = velocity;
    }
}
