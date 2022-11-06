using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public GameObject[] lights;
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Interact() 
    {
        active = !active;
        foreach (GameObject light in lights) 
        {
            if (active == true)
            {
                light.SetActive(true);
            }
            else 
            {
                light.SetActive(false);
            }
        }
    }
}
