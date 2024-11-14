using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject enemigoPrefab;
    [SerializeField] private Transform[] puntoSpawn;
    void Start()
    {

        Instantiate(enemigoPrefab, puntoSpawn[Random.Range(0,puntoSpawn.Length)].position, Quaternion.identity);
        StartCoroutine(PuntosDeSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator  PuntosDeSpawn()
    {

        while (true) 
        { 
            Instantiate
        
        
        }
    
    }
}
