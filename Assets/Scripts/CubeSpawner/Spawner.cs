using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float BeginRecharge = 2;
    public float BeginVelocity = 10;
    public GameObject SpawnPrefab;
    public CountObjController CountObjController;
    public SpawnerBody[] Spawners;

    private float _time;
    private float _recharge;
    private float _velocity;

    
    void Start()
    {
        _time = 0;
        _recharge = BeginRecharge;
        _velocity = BeginVelocity;
    }

    void Update()
    {
        _time += Time.deltaTime;

        if (_time > _recharge)
        {
            _time -= _recharge;


            if (CountObjController.CanAdd())
            {
                SpawnerBody sb = Spawners[Random.Range(0, Spawners.Length)];
                sb.spawn(SpawnPrefab, _velocity);
                CountObjController.Increase();
            }
        }
    }

    public void UpdateRecharge(float cooldown)
    {
        this._recharge = cooldown;
    }
    public void UpdateVelocity(float velocity)
    {
        this._velocity = velocity;
    }
}
