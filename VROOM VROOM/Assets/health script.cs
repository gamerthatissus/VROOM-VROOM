using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerZoneIdentifier354 : MonoBehaviour
{
    public ParticleSystem effect2;
    public Rigidbody player;
    public ParticleSystem effect1;                                                                               
    public float hp=100;
    public Transform particals;
    private void OnTriggerEnter(Collider other)                                                                   
    {                                                                                                             
                                                                                                                  
        if (other.gameObject.name == "hit")
        {
            Destroy(other.gameObject);
            if (hp > 10)
            {
                hp -= 10;
                particals.position = player.position;
                effect1
            }
            else
            {
                Destroy(player);
                
                
            }
            
        }        

    }                                                                                                             
}