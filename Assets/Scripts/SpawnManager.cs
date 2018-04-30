using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawns;
    public int increase_spawn_count;
    public float wave_length;

    private int wavecount;
    int spawn_count;
    bool is_wave_active;


    private void Update()
    {
        if(!is_wave_active)
        {
            is_wave_active = true;
            StartCoroutine(WaveCount());
          
        }
    }

    IEnumerator WaveCount()
    {
        wavecount++;
        spawn_count += increase_spawn_count;

        for (int i = 0; i < spawn_count; i++)
        {
            Transform spawnPosition = spawns[Random.Range(0, spawns.Length)];
            Instantiate(enemy, spawnPosition.position, spawnPosition.rotation);
        }

        yield return new WaitForSeconds(wave_length);
        is_wave_active = false;
    }
}
