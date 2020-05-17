using System;
using System.Collections;
using UnityEngine;
using Random = System.Random;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform fastEnemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 1;
    private GameObject[] enemies;

    private void Start()
    {
        
    }

    void Update()
    {
        // if (countdown <=0f)
        // {
        //     StartCoroutine(SpawnWave());
        //     countdown = timeBetweenWaves;
        // }
        // countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;
        for (int i = 0; i < waveNumber*2; i++)
        {
            if (UnityEngine.Random.Range(0,100)>80)
            {
                SpawnEnemy("fast");
            }
            else
            {
                SpawnEnemy("normal"); 
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnEnemy(String type)
    {
        if (type.Equals("normal"))
        {
            Instantiate(enemyPrefab,spawnPoint.position, spawnPoint.rotation);
        }
        else if (type.Equals("fast"))
        {
            Instantiate(fastEnemyPrefab,spawnPoint.position, spawnPoint.rotation);
        }
        // TODO Mehr gegner Prefabs
        // TODO gegner zur liste hinzufügen
    }

    public void StartSpawnWave(GameObject button)
    {
        button.GetComponent<NextButtonScript>().SetActivateButton(false);
        MoneyScript.Money += waveNumber * 100 % 1000;
        // TODO Bessere Drop rate
        StartCoroutine(SpawnWave());
    }
    
}
