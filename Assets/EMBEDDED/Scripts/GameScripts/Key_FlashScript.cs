using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_FlashScript : MonoBehaviour
{
    public GameObject GO;
    AudioSource AS;
    GameObject Player; 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        AS = GO.GetComponent<AudioSource>();
               
    }
    void Interact() 
    {
        Player.GetComponent<MonologScript>().EventNum++;
        AS.Play();
        Destroy(gameObject);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
