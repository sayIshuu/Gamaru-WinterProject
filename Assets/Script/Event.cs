using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Event
{
    [SerializeField]
    private string eventName;
    [SerializeField]
    private int eventID;
    [SerializeField]
    private string eventText;
    [SerializeField]
    private List<Selection> selections;

    public string getEventName()
    {
        return eventName;
    }

    public string getEventText()
    {
        return eventText;
    }

    public Event getThisEvent()
    {
        return (Event) MemberwiseClone();
    }
}
