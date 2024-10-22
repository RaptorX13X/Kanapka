using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> ingredientsPrefabs;
    [SerializeField] private Transform spawner;
    [SerializeField] private Transform leftSide;
    [SerializeField] private Transform rightSide;
    [SerializeField] private float waitTime;
    [SerializeField] private float bunCooldown = 3f;
    [SerializeField] private float roundTime = 20f;

    [SerializeField] private GameObject endBun;
    private bool canSpawn = true;

    private void Start()
    {
        StartCoroutine(SpawningRoutine());
        StartCoroutine(TimerRoutine());
    }

    public void StartSpawning()
    {
        canSpawn = true;
        StartCoroutine(SpawningRoutine());
        StartCoroutine(TimerRoutine());
    }

    public void StopBun()
    {
        StopAllCoroutines();
    }
    IEnumerator SpawningRoutine()
    {
        while (canSpawn)
        {
            Instantiate(ingredientsPrefabs[Random.Range(0, ingredientsPrefabs.Count)], new Vector3(Random.Range(leftSide.position.x, rightSide.position.x), spawner.position.y, spawner.position.z),transform.rotation * Quaternion.Euler(-90,0,0));
            yield return new WaitForSeconds(waitTime);
        }
    }

    IEnumerator TimerRoutine()
    {
        yield return new WaitForSeconds(roundTime);
        canSpawn = false;
        StopAllCoroutines();
        StartCoroutine(EndBun());
    }

    IEnumerator EndBun()
    {
        while (!canSpawn)
        {
            yield return new WaitForSeconds(bunCooldown);
            Instantiate(endBun,
                new Vector3(Random.Range(leftSide.position.x, rightSide.position.x), spawner.position.y,
                    spawner.position.z), quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
