using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private Transform[] _spawners;
    private int _nextSpawnerIndex;
    private float _spawnDelay = 2f;

    void Awake()
    {
        _spawners = GetComponentsInChildren<Transform>();
        StartCoroutine(SpawnWithDelay());
    }

    private IEnumerator SpawnWithDelay()
    {
        while (true)
        {
            if (!_spawners[_nextSpawnerIndex].Equals(transform))
            {
                Instantiate(_prefab, _spawners[_nextSpawnerIndex].position, Quaternion.identity);
                yield return new WaitForSeconds(_spawnDelay);
            }

            _nextSpawnerIndex++;
            if (_nextSpawnerIndex >= _spawners.Length)
                _nextSpawnerIndex = 0;
            
        }
    }
}
