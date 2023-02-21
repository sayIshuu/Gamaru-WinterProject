using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventDB : MonoBehaviour
{
    private static EventDB instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //게임 매니저 인스턴스에 접근할 수 있는 프로퍼티. static이므로 다른 클래스에서 맘껏 호출할 수 있다.
    public static EventDB Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }


    public List<Event> events;

    void Start()
    {
        EventManager.Instance.eventStart(events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventID));
    }
}
