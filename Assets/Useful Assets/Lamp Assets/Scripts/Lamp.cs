using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {


    public GameObject LampLight;

    public GameObject DomeOff;


    public GameObject DomeOn;

    public bool TurnOn;


    // Use this for initialization
    void Start () 
    {
    }


    void Interact() 
    {
        TurnOn = !TurnOn;
        if (TurnOn == true)
        {
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);

        }
        if (TurnOn == false)
        {

            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);

        }
    }
}
