using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaAutomatica : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera cam;
    [SerializeField] private ArmaSo misDatos;
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            System.Play();
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, misDatos)) 
            {
                if (hitInfo.transform.CompareTag("")) 
                { 
                
                
                
                }
            
            }


        }
    }
    




}
