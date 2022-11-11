using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip[] AudClips;
    public AudioClip Scrmr;
    public float Vol;
    bool Active = true;
    int num = -1;
    // Start is called before the first frame update
    void Start()
    {
        AS.Play();
        AS.volume = 0f;
    }
    public void Scrm() 
    {
        AS.clip = Scrmr;
        AS.volume = 1f;
        AS.Play();
    }
    void Interact() 
    {
        Active = !Active;
        if (Active)
        {
            AS.volume = Vol;
        }
        else 
        {
            AS.volume = 0f;
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (AS.isPlaying == false)
        {
            num++;
            AS.clip = AudClips[num];
            AS.Play();
        }
        if (num == AudClips.Length)
        {
            num = 0;
        }
    }
}
