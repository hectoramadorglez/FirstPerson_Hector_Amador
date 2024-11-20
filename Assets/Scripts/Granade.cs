using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
   
    private Rigidbody rb;
    [SerializeField] private float fuerzaImpulso;
    [SerializeField] private GameObject explosion;
    void Start()
    {
      
        GetComponent<Rigidbody>().AddForce(transform.forward);
        Destroy(gameObject,1.5f);
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(1, 1, 1) * Random.Range(0, 500) * Time.deltaTime);
    }
    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
