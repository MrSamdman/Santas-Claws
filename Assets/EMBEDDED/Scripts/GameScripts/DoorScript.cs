using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int EvNum = 2;
    bool IntAl = false;
    bool Active;
    Animation DoorOp;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Active = false;
        DoorOp = GetComponent<Animation>();
    }
    void Interact() 
    {
        if (Player.GetComponent<MonologScript>().EventNum >= EvNum) 
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
        else if (IntAl == false)
        {
            IntAl = true;
            Player.GetComponent<MonologScript>().EventShowing(3);
        }
            
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
