using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventDB : MonoBehaviour
{
    public List<Event> events;

    void Start()
    {
        EventManager.Instance.eventStart(events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventNameID));
    }

}
