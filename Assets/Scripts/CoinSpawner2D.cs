using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner2D : MonoBehaviour
{
    public GameObject coinPrefab;    
    public Transform spawnPoint;     
    public float lifetime = 5f;
    Rigidbody rb;

    void Start()
    {
        StartCoroutine(SpawnAndDisappear());
        rb = GetComponent<Rigidbody>();
    }

    

    IEnumerator SpawnAndDisappear()
    {   
        Vector2 spawnPosition = new Vector2(spawnPoint.position.x, spawnPoint.position.y);
        GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(lifetime);
        coin.SetActive(false);
    }
}
