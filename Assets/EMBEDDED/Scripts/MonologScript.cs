using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonologScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI txt_mesh;
    string[] Text = new string[400];
    public int TriggerNum = 0;
    public int EventNum = 0;
    string Output;
    bool Cycle = false;
    int TriggerSelfNum;
    Collider Other;
    // Start is called before the first frame update
    void Start()
    {
        Texting();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TextTriggerExit")& TriggerNum == other.GetComponent<TextTriggerScript>().TextNum)
        {
            Other = other;
            TriggerSelfNum = other.GetComponent<TextTriggerScript>().TextNum;
            StartCoroutine("SlowShowing");
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("TextTrigger") & TriggerNum == other.GetComponent<TextTriggerScript>().TextNum)
        {
            Other = other;
            TriggerSelfNum = other.GetComponent<TextTriggerScript>().TextNum;
            StartCoroutine("SlowShowing");
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void EventShowing(int PhraseNum) 
    {
        TriggerSelfNum = PhraseNum;
        StartCoroutine("SlowShowing");
    }
    IEnumerator SlowShowing() 
    {
        int Cur = TriggerSelfNum;
        if (Cycle == true)
        {
            yield return new WaitForSeconds(1f);
            StartCoroutine("SlowShowing");
        }
        else
        {
            Cycle = true;
            Output = "";
            TriggerNum++;
            txt_mesh.text = "";
            foreach (char letter in Text[Cur])
            {
                Output += letter;
                txt_mesh.text = Output;
                yield return new WaitForSeconds(0.15f);
            }
            yield return new WaitForSeconds(3f);
            txt_mesh.text = "";
            Cycle = false;
        }
        
        
        

    }
    
    void Texting()
    {
        Text[0] = "It's time to get up.";
        Text[1] = "Where is my key?";
        Text[2] = "Also I need a flaslight";
        Text[3] = "Can't do it now.";
    }

}
