using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {


    public GameObject LampLight;

    public GameObject DomeOff;


    public GameObject DomeOn;

    public bool TurnOn;
    AudioSource Click;

    // Use this for initialization
    void Start () 
    {
        Click = GetComponent<AudioSource>();
    }


    void Interact() 
    {
        TurnOn = !TurnOn;
        if (TurnOn == true)
        {
            Click.Play();
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);

        }
        if (TurnOn == false)
        {
            Click.Play();
            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);

        }
    }
}
