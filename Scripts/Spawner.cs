using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Ground _groundPrefab;
    [SerializeField] private float _secondsBetwinSpawn;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            int randomSpawn = Random.Range(0, _spawnPoints.Length);

            Instantiate(_groundPrefab, _spawnPoints[randomSpawn].position, Quaternion.identity);

            yield return new WaitForSeconds(_secondsBetwinSpawn);
        }
    }
}


