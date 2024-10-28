using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float velociadMovimiento;
    [SerializeField] private float smoothTime;
    CharacterController controller;
    private float velocidadRotacion;
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
        Vector3 input = new Vector2(h, v).normalized;

        float anguloRotacion = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

        float anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloRotacion,ref velocidadRotacion , smoothTime);
        transform.eulerAngles = new Vector3(0, anguloSuave, 0);

        if (input.magnitude > 0)
        {

            
            

            Vector3 movimiento = Quaternion.Euler(0, anguloRotacion, 0) * Vector3.forward;
            controller.Move(movimiento * velociadMovimiento * Time.deltaTime);
        }
    }
    



}
