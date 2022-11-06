using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    RaycastHit Hit;
    public GameObject mushka;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 Dir = mushka.transform.position - transform.position;
        Ray IntRay = new Ray(transform.position, Dir);
        if (Input.GetMouseButtonDown(0)) 
        {
            Physics.Raycast(IntRay, out Hit, maxDistance:0.8f);             
            Hit.collider.SendMessage("Interact");
            Debug.Log(Hit.collider.name);
            Debug.Log("AAA");
        }
    }
}
