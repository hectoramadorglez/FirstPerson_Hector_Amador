using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float velociadMovimiento;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverYRotar();
    }
    void MoverYRotar() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 movimiento = new Vector3(h, 0, v).normalized;
        float anguloRotacion =  Mathf.Atan2(movimiento.x, movimiento.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
        if (movimiento.magnitude > 0) 
        { 
        
            transform.eulerAngles = new Vector3(0, anguloRotacion,0);
        
        }
        transform.eulerAngles = new Vector3 (0, anguloRotacion,0);
        controller.Move(movimiento * velociadMovimiento * Time.deltaTime);
            
        
        
        
        
    }
}
