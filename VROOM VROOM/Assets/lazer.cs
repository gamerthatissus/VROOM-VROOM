using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerZoneIdentifier2 : MonoBehaviour
{

                                                                                          
    public string zoneName;                                                                                        

    private void OnTriggerEnter(Collider other)                                                                   
    {                                                                                                             
        Debug.Log("Other is inside: " + zoneName);                                                                
                                                                                                                  
        if (other.gameObject.name == "hit")
        {
           Destroy(other.gameObject);
               
           
        }        

    }                                                                                                             
}