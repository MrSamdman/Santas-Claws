using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksScript : MonoBehaviour
{
    int count = 0;
    public GameObject[] Fireworks;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(3, 10);
    }
    void StartFire() 
    {
        StartCoroutine("Fire");
    }
    IEnumerator Fire() 
    {
        Instantiate(Fireworks[Random.Range(0, Fireworks.Length)],gameObject.transform.position, rotation: Quaternion.Euler(Random.Range(-15f, 15f), Random.Range(-15f, 15f), Random.Range(-15f, 15f)));
        yield return new WaitForSeconds(Random.Range(2f, 5f));
        count++;
        if (count < num) 
        {
            StartCoroutine("Fire");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
