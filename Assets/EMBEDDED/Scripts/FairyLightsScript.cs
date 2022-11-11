using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyLightsScript : MonoBehaviour
{
    Color SColor;
    float n = 0;
    GameObject glass;
    public Material Mat;
    GameObject[] Lights;
    Light PointLightLight;
    bool Mode = false;
    public GameObject PointLights;
    // Start is called before the first frame update
    void Start()
    {
        PointLightLight = PointLights.GetComponent<Light>();
        Lights = GameObject.FindGameObjectsWithTag("FairyLight");
        StartCoroutine("ChangingForAll");
        n = PointLightLight.intensity / Lights.Length;
        Debug.Log(n);
    }
    IEnumerator SequentialOffing() 
    {
        foreach (GameObject light in Lights)
        {
            glass = light.transform.GetChild(0).gameObject;
            glass.SetActive(false);
            PointLightLight.intensity = PointLightLight.intensity - n;
            yield return new WaitForSeconds(0.1f);
        }
        SColor = new Color(Random.Range(0.0f, 1.1f), Random.Range(0.0f, 1.1f), Random.Range(0.0f, 1.1f), 1);
        PointLightLight.color = SColor;
        Mat.SetColor("_EmissionColor", SColor);
        StartCoroutine("SequentialActiv");
    }
    IEnumerator SequentialActiv() 
    {
        foreach (GameObject light in Lights)
        {
            glass = light.transform.GetChild(0).gameObject;
            glass.SetActive(true);
            PointLightLight.intensity = PointLightLight.intensity + n;
            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine("SequentialOffing");
    }

    IEnumerator ChangingForAll() 
    {
        Color Col = new Color(Random.Range(0.0f, 1.1f), Random.Range(0.0f, 1.1f), Random.Range(0.0f, 1.1f), 1);
        Mat.SetColor("_EmissionColor",Col);
        PointLightLight.color = Col;
        yield return new WaitForSeconds(2f);
        StartCoroutine("ChangingForAll");
    }
    void Interact() 
    {
        Mode = !Mode;
        if (Mode)
        {
            StopAllCoroutines();
            StartCoroutine("SequentialOffing");
        }
        else 
        {
            StopAllCoroutines();
            foreach (GameObject light in Lights)
            {
                glass = light.transform.GetChild(0).gameObject;
                glass.SetActive(true);
            }
            StartCoroutine("ChangingForAll");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
