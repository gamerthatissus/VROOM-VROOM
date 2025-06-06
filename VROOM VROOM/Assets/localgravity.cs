using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class TriggerZoneIdentifier3 : MonoBehaviour
{
    public Rigidbody playerrb;
    public Rigidbody cartRB1;
    public Rigidbody cartRB2;
    public Rigidbody cartRB3;

    

                                                                                          
    public string zoneName;                                                                                        

    private void OnTriggerEnter(Collider other)                                                                   
    {            
        
        Debug.Log("Other is inside: " + zoneName);                                                                
                                                                                                                  
        if (other.gameObject.name == "player" || other.gameObject.name == "train cart"|| other.gameObject.name == "train cart1"|| other.gameObject.name == "train cart2")
        {
            playerrb.useGravity = true;
            cartRB1.useGravity = true;
            cartRB2.useGravity = true;
            cartRB3.useGravity = true;
            playerrb.velocity = new Vector3(0, 0, 0);
            cartRB1.mass = 200;
            cartRB2.mass = 200;

            cartRB3.mass = 200;


        }      
        
        

    }    
    
    private void OnTriggerExit(Collider other)                                                                   
    {            
        
        Debug.Log("Other is inside: " + zoneName);                                                                
                                                                                                                  
        if (other.gameObject.name == "player" || other.gameObject.name == "train cart"|| other.gameObject.name == "train cart1"|| other.gameObject.name == "train cart2")
        {
            cartRB1.mass = 0.1f;
            cartRB2.mass = 0.1f;

            cartRB3.mass = 0.1f;

            playerrb.useGravity = false;
            cartRB1.useGravity = false;
            cartRB2.useGravity = false;
            cartRB3.useGravity = false;
        }      
        
        

    }    
}