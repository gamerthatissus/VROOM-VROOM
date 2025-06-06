using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;

    public float speeed = 0;

    public float rotx = 0;

    public float roty = 0;
    
    public float rotz = 0;

    public bool isUpsideDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
        if (Input.GetKey(KeyCode.W))
        {
            if (roty < 10)
            {
                roty += 0.3f;

            }
            else
            {
                roty = 10;
                
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (roty > -10)
            {
                roty -= 0.3f;

            }
            else
            {
              
                    roty = -10;
                
            }
        }
        else
        {
            if (roty>0 || roty<0)
            {
            
                if (Math.Abs(roty)<0.1f )
                {
                    roty = 0;
            
            
                }
                else
                {
                    if (roty > 0.05 || roty<-0.05 )
                    {
                        roty *= 0.6f;
                    }
            
                } 
            
            
            }
        }

       
        if (Input.GetKey(KeyCode.Z))
        {
            if (rotz < 10)
            {
                rotz += 0.3f;

            }
            else
            {
                rotz = 10;
                
            }
        }
        else if (Input.GetKey(KeyCode.X))
        {
            if (rotz > -10)
            {
                rotz -= 0.3f;

            }
            else
            {
              
                rotz = -10;
                
            }
        }
        else
        {
            if (rotz>0 || rotz<0)
            {
            
                if (Math.Abs(rotz)<0.1f )
                {
                    rotz = 0;
            
            
                }
                else
                {
                    if (rotz > 0.05 || rotz<-0.05 )
                    {
                        rotz *= 0.6f;
                    }
            
                } 
            
            
            }
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            if (rotx < 10)
            {
                rotx += 0.3f;

            }
            else
            {
              
                    rotx = 10;
                
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (rotx > -10)
            {
                rotx -= 0.3f;

            }
            else
            {
              
                    rotx = -10;
                
            }
        }
        else
        {
            if (rotx>0 || rotx<0)
            {
            
                if (Math.Abs(rotx)<0.1f )
                {
                    rotx = 0;
            
            
                }
                else
                {
                    if (rotx > 0.05 || rotx<-0.05 )
                    {
                        rotx *= 0.6f;
                    }
            
                } 
            
            
            }
        }

        rb.angularVelocity = rb.transform.TransformDirection(new Vector3(roty/2,rotx/2,rotz/2));
        rb.velocity = transform.forward * (-speeed*1.3f);
     
        if (rb.useGravity == false)
        {
            rb.isKinematic = false;
        }
        else
        {
            rb.isKinematic = true;

        }
     
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (speeed < 20)
            {
                speeed += 0.15f;

            }
            else
            {
                if (speeed < 30)
                {
                    speeed += 0.04f;

                }
                else
                {
                    speeed = 30;
                }
            }
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            if (speeed > -20)
            {
                speeed -= 0.15f;

            }
            else
            {
                if (speeed > -30)
                {
                    speeed -= 0.04f;

                }
                else
                {
                    speeed = -30;
                }
            }
        }
        else
        {
            if (speeed>0 || speeed<0)
            {
            
                if (Math.Abs(speeed)<0.1f )
                {
                    speeed = 0;
            
            
                }
                else
                {
                    if (speeed > 0.05 || speeed<-0.05 )
                    {
                        speeed *= 0.9f;
                    }
            
                } 
            
            
            }
        }


  

       
        
        
         
        
       
        
        
    }
}
