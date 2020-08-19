using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreator : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPositions;
    [SerializeField] private GameObject[] _monsters;
    [SerializeField] private float _timeBetweenSpawning;
    

    private void Start()
    {
        StartCoroutine(SpawnNewEnemies(_timeBetweenSpawning));
    }

    private IEnumerator SpawnNewEnemies(float timeBetweenSpawning)
    {
        var waitForSeconds = new WaitForSeconds(timeBetweenSpawning);
        while (true)
        {
            int randomMonsterNumber = Random.Range(0, _monsters.Length);
            int randomSpawnPosition = Random.Range(0, _spawnPositions.Length);

            Instantiate(_monsters[randomMonsterNumber], _spawnPositions[randomSpawnPosition].position, Quaternion.identity);
            yield return waitForSeconds;
        }
    }
}
