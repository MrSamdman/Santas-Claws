using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Spawner.GetComponent<FireworksScript>().SendMessage("StartFire");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
