using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;    
    public Transform spawnPoint;     
    public float lifetime = 5f;      

    void Start()
    {
        StartCoroutine(SpawnAndDisappear());
    }

    IEnumerator SpawnAndDisappear()
    {
        GameObject coin = Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(lifetime);
        coin.SetActive(false);
    }
}
