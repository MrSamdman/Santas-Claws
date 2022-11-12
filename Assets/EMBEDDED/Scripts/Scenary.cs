using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public interface Action
{
    public string tag { get; set; }
    public void makeAction();    
    //{

    //}
    /*
    List<Action> GetAll()
    {
        return typeof(Action).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(Action))).ToList();
    }         
    */
}

public class DoorAction: Action
{
    public string tag { get; set; }
    public void makeAction()
    {
        Debug.Log("here");
        GameObject.FindGameObjectWithTag("Radio").GetComponent<RadioScript>().Scrm();
    }
}

public class LightAction : Action
{
    public string tag { get; set; }
    public void makeAction()
    {
        GameObject.FindGameObjectWithTag("Radio").GetComponent<RadioScript>().Scrm();
    }
}



public class Scenary : MonoBehaviour
{
    List<Action> actions = new List<Action>() {
        new DoorAction{tag = "DoorScript"}, 
        new LightAction{tag = "Light"}  
    };

    

    private void Start()
    {
    }

    public void makeNextAction(string objectTag)
    {
        if (actions.Count() == 0)
        {
            Debug.Log("В очереди 0 объектов, но пытается вызвать класс:");
            Debug.Log(objectTag);
            return;
        }
        
        if (objectTag == actions[0].tag)
        {
            Debug.Log("Executed:");
            Debug.Log(objectTag);
            actions[0].makeAction();
            actions.RemoveAt(0);
        }
        else
        {
            Debug.Log("Не подошла очереь объекта:");
            Debug.Log(objectTag);
            Debug.Log("текущий первый объект:");
            Debug.Log(actions[0].tag);
        }
    }
}

