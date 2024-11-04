using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anim;
    private NavMeshAgent agent;
    private bool ventanaAbierta;
    [SerializeField]private float radioAtaque;
    [SerializeField] private int layerMask;
    [SerializeField] private Transform attackPoint;
    private bool puedoDanhar = true;
    //private Personaje player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        
        //player = GameObject.FindAnyObjectByType<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir();
        if(ventanaAbierta && puedoDanhar) 
        {
            DetectarImpacto();
        }    
       
    }
    private void DetectarImpacto()
    {
       Collider[] collsDetectados = Physics.OverlapSphere(attackPoint.position, radioAtaque, layerMask);
        
        if (collsDetectados.Length > 0) 
        {
            for (int i = 0; i < collsDetectados.Length; i++)
            {
                //collsDetectados[i].GetComponent<Personaje>().RecibirDanho(danhoEnemigo);
            } 
            puedoDanhar=false;
        }     
        
        
        
        

    }
   
    private void Perseguir() 
    { 
        //agent.SetDestination(player.transform.position);  
        if(agent.remainingDistance<= agent.stoppingDistance) 
        { 
        
        
        
        
        }
        
    
    
    }
    private void FinAtaque() 
    { 
        agent.isStopped = false;
        anim.SetBool("atacking", false);
    
    
    }
    private void AbrirVentana() 
    { 
        ventanaAbierta = true;

    }
    private void CerrarVentanaAtaque() 
    { 
  
        ventanaAbierta = false;
    }
}
