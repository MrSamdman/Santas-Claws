using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool Active;
    Animation DoorOp;
    // Start is called before the first frame update
    void Start()
    {
        Active = false;
        DoorOp = GetComponent<Animation>();
    }
    void Interact() 
    {
        Active = !Active;
        if (Active)
        {
            DoorOp.Play("DoorOpening");
        }
        if (!Active)
        {
            DoorOp.Play("DoorClosing");
        }

    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
