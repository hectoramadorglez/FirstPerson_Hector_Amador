using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaManual : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ArmaSo misDatos;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        { 
        
           if( Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, misDatos.distanciaAtaque)) 
            {
                Debug.Log(hitInfo.transform.name);
            
            }
        
        }
    }
}
