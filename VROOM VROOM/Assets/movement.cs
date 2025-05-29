using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;

    public float speeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        rb.velocity = transform.forward * speeed;
        
        if (Input.GetKey(KeyCode.W))
        {
            if (speeed < 20)
            {
                speeed += 1;

            }
            else
            {
                if (speeed < 30)
                {
                    speeed += 0.3f;

                }
                else
                {
                    speeed = 30;
                }
            }
        }
        else
        {
            if (speeed ! == 0)
            {
            
                if (speeed < 0.5 )
                {
                    speeed = 0;
            
            
                }
                else
                {
                    if (speeed > 0.4)
                    {
                        speeed = speeed * 0.9f;
                    }
            
                } 
            
            }
        }

       
        
        
         
        
       
        
        
    }
}
