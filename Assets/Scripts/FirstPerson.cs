using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float velociadMovimiento;
    CharacterController controller;
    [SerializeField] private float factorGravedad;
    [SerializeField] private float movimientoVertical;
    [SerializeField] private float radioDeteccion;
    [SerializeField] private Transform pies;
    [SerializeField] private LayerMask queEsSuelo;
        void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverYRotar();
        AplicarGravedad();
        EnSuelo();
    }
    void MoverYRotar()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 input = new Vector2(h, v).normalized;

        float anguloRotacion = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

       
        transform.eulerAngles = new Vector3(0, anguloRotacion, 0);

        if (input.magnitude > 0)
        {




            Vector3 movimiento = Quaternion.Euler(0, anguloRotacion, 0) * Vector3.forward;
            controller.Move(movimiento * velociadMovimiento * Time.deltaTime);
        }
    }
    private void AplicarGravedad() 
    {
       
    
    
    }

   // private bool EnSuelo() 
    //{

        //Physics.CheckSphere(pies.position, radioDeteccion, queEsSuelo);
            
    
    
    //}







}

