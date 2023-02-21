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
    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
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
