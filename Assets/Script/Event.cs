using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Event
{
    [SerializeField]
    public string eventName;
    [SerializeField]
    private int eventID;
    [SerializeField]
    private string eventText;
    [SerializeField]
    private List<Selection> selections;
}
