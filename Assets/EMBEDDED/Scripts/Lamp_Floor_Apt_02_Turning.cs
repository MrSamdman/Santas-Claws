using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp_Floor_Apt_02_Turning : MonoBehaviour
{
    MeshRenderer mesh;
    Material CurMat;
    public Material NewMat;
    public GameObject light;
    bool Active = false;
    AudioSource Click;
    // Start is called before the first frame update
    void Start()
    {
        light.SetActive(false);
        mesh = gameObject.GetComponent<MeshRenderer>();
        CurMat = gameObject.GetComponent<MeshRenderer>().material;
        mesh.material = NewMat;
        Click = GetComponent<AudioSource>();
    }

    void Interact() 
    {
        Active = !Active;
        if (Active == true)
        {
            Click.Play();
            light.SetActive(true);
            mesh.material = CurMat;
        }
        else 
        {
            Click.Play();
            light.SetActive(false);
            mesh.material = NewMat;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
