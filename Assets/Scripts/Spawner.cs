using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> ingredientsPrefabs;
    [SerializeField] private Transform spawner;
    [SerializeField] private Transform leftSide;
    [SerializeField] private Transform rightSide;
    [SerializeField] private float waitTime;

    private void Start()
    {
        StartCoroutine(SpawningRoutine());
    }

    IEnumerator SpawningRoutine()
    {
        while (true)
        {
            Instantiate(ingredientsPrefabs[Random.Range(0, ingredientsPrefabs.Count)], new Vector3(Random.Range(leftSide.position.x, rightSide.position.x), spawner.position.y, spawner.position.z), quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
