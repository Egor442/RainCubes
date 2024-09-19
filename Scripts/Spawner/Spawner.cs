using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private float _secondsBetweenSpawn;

    private Transform[] _spawnPoints;
    private float _elepsedTime;

    public void Initialize()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();

        _elepsedTime = 0;
        InitializePrefabe(_prefabs);
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elepsedTime = 0;

                int spawnPointRandom = Random.Range(0, _spawnPoints.Length);
                SetObject(enemy, _spawnPoints[spawnPointRandom].position);
            }
        }
    }

    private void SetObject(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}