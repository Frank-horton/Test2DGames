using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : Enemy
{
    private float _waitTime;
    private Vector2 _enemyPoint; 

    [SerializeField] private Vector2 _sizeMoveblePoint;
    [SerializeField] private float speed;
    [SerializeField] private float StartWaitTime;

    private void Start()
    {
        _waitTime = StartWaitTime;
        _enemyPoint = GetEnemyPoint();
    }

    private void Update()
    {
        RandomMove();
    }

    private void RandomMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, _enemyPoint, speed * Time.deltaTime);

        float dist = Vector2.Distance(transform.position, _enemyPoint);
        if (dist > 0.2f) return;

        _waitTime -= Time.deltaTime;
        if (_waitTime <= 0)
        {
            _enemyPoint = GetEnemyPoint(); 
            _waitTime = StartWaitTime;
        }
    }
    private Vector2 GetEnemyPoint()
    {
        return new Vector2(Random.Range(-_sizeMoveblePoint.x, _sizeMoveblePoint.x), Random.Range(-_sizeMoveblePoint.y, _sizeMoveblePoint.y));
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(Vector3.zero, _sizeMoveblePoint * 2f);
    }
}