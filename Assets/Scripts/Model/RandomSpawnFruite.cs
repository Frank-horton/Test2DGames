using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnFruite : MonoBehaviour
{
    [SerializeField] private Vector2 _spawnSizeMoveblePoint;
    [SerializeField] private GameObject _object;
    [SerializeField] private float _spawnRate = 2f;

    private float _randX;
    private float _randY;
    private Vector2 _whereToSpawn;
    private float _nextSpawn = 0.0f;

    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time > _nextSpawn)
        {
            _nextSpawn = Time.time + _spawnRate;
            _randX = Random.Range(-_spawnSizeMoveblePoint.x, _spawnSizeMoveblePoint.x);
            _randY = Random.Range(-_spawnSizeMoveblePoint.y, _spawnSizeMoveblePoint.y);
            _whereToSpawn = new Vector2(_randX, _randY);
            Instantiate(_object, _whereToSpawn, Quaternion.identity);
        }
    }
}