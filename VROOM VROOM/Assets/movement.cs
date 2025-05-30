using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;

    public float speeed = 0;

    public float rotx = 0;

    public float roty = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.W))
        {
            if (roty < 20)
            {
                roty += 0.1f;

            }
            else
            {
                if (roty < 30)
                {
                    roty += 0.3f;

                }
                else
                {
                    roty = 30;
                }
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (roty > -20)
            {
                roty -= 0.1f;

            }
            else
            {
                if (roty > -30)
                {
                    roty -= 0.3f;

                }
                else
                {
                    roty = -30;
                }
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
                        roty *= 0.99f;
                    }
            
                } 
            
            
            }
        }
        
        
        if (Input.GetKey(KeyCode.D))
        {
            if (rotx < 20)
            {
                rotx += 0.1f;

            }
            else
            {
                if (rotx < 30)
                {
                    rotx += 0.3f;

                }
                else
                {
                    rotx = 30;
                }
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (rotx > -20)
            {
                rotx -= 0.1f;

            }
            else
            {
                if (rotx > -30)
                {
                    rotx -= 0.3f;

                }
                else
                {
                    rotx = -30;
                }
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
                        rotx *= 0.99f;
                    }
            
                } 
            
            
            }
        }

        rb.angularVelocity = new Vector3(roty/3, rotx/3, 0);
        rb.velocity = transform.forward * -speeed;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speeed < 20)
            {
                speeed += 0.1f;

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
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (speeed > -20)
            {
                speeed -= 0.1f;

            }
            else
            {
                if (speeed > -30)
                {
                    speeed -= 0.3f;

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
                        speeed *= 0.99f;
                    }
            
                } 
            
            
            }
        }


  

       
        
        
         
        
       
        
        
    }
}
