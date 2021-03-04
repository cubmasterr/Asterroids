using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private float MeteorTimer, ShipsTimer;
    [SerializeField] GameObject Meteor, Ship;
    [SerializeField] private Transform[] SpaunPoints;
    private float _MeteorTimer, _ShipsTimer;
    private void Start()
    {
        _MeteorTimer = MeteorTimer;
        _ShipsTimer = ShipsTimer;
        SpaunPoints = gameObject.GetComponentsInChildren<Transform>();
    }
    private void Update()
    {
        if (_ShipsTimer <= 0)//cheack ships Timer
        {
            _ShipsTimer = ShipsTimer;
            Instantiate(Ship, SpaunPoints[UnityEngine.Random.Range(1, 4)].position, Quaternion.identity);//Spawn ship for 4 spawn top point
        }
        else
        {
            _ShipsTimer -= Time.deltaTime;
        }     
        if (_MeteorTimer <= 0)//cheack Meteor Timer
        {
            _MeteorTimer = MeteorTimer;
            Instantiate(Meteor, SpaunPoints[UnityEngine.Random.Range(1, 9)].position, Quaternion.identity);//Meteor ship for 8 spawn  point
        }
        else
        {
            _MeteorTimer -= Time.deltaTime;
        }
    }
}
