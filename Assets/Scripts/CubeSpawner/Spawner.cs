using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float CoolDown = 2;
    [SerializeField]
    private float velocity = 10;
    [SerializeField]
    private GameObject spawn_object;

    private float time;

    SpawnerBody[] spawners;
    void Start()
    {
        spawners = getSpawnerBodies();
        time = 0;
        
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > CoolDown)
        {
            SpawnerBody sb = spawners[Random.Range(0, spawners.Length )];
            sb.spawn(spawn_object,velocity);

            time -= CoolDown;
        }
    }

    

    SpawnerBody[] getSpawnerBodies()
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
}
