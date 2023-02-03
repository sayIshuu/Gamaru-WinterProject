using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EventDB : MonoBehaviour
{
    public List<Event> events;

    ///public Event[,] eventArray;

    //public static Dictionary<string, int> eventNameKey;
    //public static Dictionary<string, Event> eventsDict = new Dictionary<string, Event>();
    //iscontainskey

    private EventManager EM;
    void Start()
    {
        //eventArray = new Event[events.Count, 1000];
        /*foreach(Event e in events)
        {
           // eventArray[]
           // eventsDict.Add(e.getEventName(), e);
        }
        */
        EM.eventStart(events.Find(x => (x.getEventName() == "튜토리얼") && (x.getEventID() == 1)));
    }


    /*public Event getEvent(string eventName, int eventId)
    {
        int eventNumber;
        eventNameKey.TryGetValue(eventName, out eventNumber);
        Event event = eventArray[eventNumber,eventId];
    return event;
    }*/

    //리스트안에 객체들이 많은데
    //그 객체의 eventid를 탐색해야돼



    public static string currentEventName;
    public static int currentEventNameID;
}
