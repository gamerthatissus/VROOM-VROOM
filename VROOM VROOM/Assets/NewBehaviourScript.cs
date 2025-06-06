using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public BoxCollider bc1;
    public BoxCollider bc2;

    public MeshRenderer rm1;
    public MeshRenderer rm2;

    public float zzzzz=0;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zzzzz > 0)
        {
            zzzzz -= 0.01f;

        }
        else
        {
            zzzzz = 0;
        }
        
        if (Input.GetKey(KeyCode.E) && zzzzz<1)
        {
            bc1.enabled = true;
            bc2.enabled = true;
            rm1.enabled = true;
            rm2.enabled = true;
            zzzzz += 0.1f;
        }
        else
        {
            bc1.enabled = false;
            bc2.enabled = false;
            rm1.enabled = false;
            rm2.enabled = false;
        }
    }
}
