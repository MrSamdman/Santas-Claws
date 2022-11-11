using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public GameObject[] lights;
    bool active = true;
    Animation SwitchON;
    AudioSource Click;

    // Start is called before the first frame update
    void Start()
    {
        SwitchON = GetComponentInChildren<Animation>();
        Click = GetComponent<AudioSource>();
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
                SwitchON.Play("SwitchOn");
                light.SetActive(true);
                Click.Play();
            }
            else 
            {
                SwitchON.Play("SwitchOff");
                light.SetActive(false);
                Click.Play();
            }
        }
    }
}
