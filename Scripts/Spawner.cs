using System.Collections;
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
        WaitForSeconds waitForSecond = new WaitForSeconds(_secondsBetwinSpawn);

        while (true)
        {
            int randomSpawn = Random.Range(0, _spawnPoints.Length);

            Instantiate(_groundPrefab, _spawnPoints[randomSpawn].position, Quaternion.identity);

            yield return waitForSecond;
        }
    }
}


