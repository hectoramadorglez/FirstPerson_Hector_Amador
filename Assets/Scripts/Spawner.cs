using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject enemigoPrefab;
    [SerializeField] private Transform[] puntoSpawn;
    [SerializeField] private int numeroNiveles;
    [SerializeField] private int esperarEntreSpawns;
    [SerializeField] private int rondasPorNivel;
    [SerializeField] private int spawnsPorRondas;
    void Start()
    {

        Instantiate(enemigoPrefab, puntoSpawn[Random.Range(0,puntoSpawn.Length)].position, Quaternion.identity);
        StartCoroutine(Spawnear());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator  Spawnear()
    {
        for (int i = 0; i < numeroNiveles;i++) 
        {
            for (int j = 0; j < rondasPorNivel; j++)
            {
                for (int k = 0; k < spawnsPorRondas; k++)
                {
                    int indiceAleatorio = Random.Range(0,puntoSpawn.Length);
                    Instantiate(enemigoPrefab, puntoSpawn[indiceAleatorio].position, Quaternion.identity);
                    yield return new WaitForSeconds(esperarEntreSpawns);

                }
                yield return new WaitForSeconds(esperarEntreSpawns);
            }
            yield return new WaitForSeconds(esperarEntreSpawns);



        }
        
    }

}
