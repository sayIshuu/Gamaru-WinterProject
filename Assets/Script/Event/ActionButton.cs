using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    public void selectionClick1()
    {
        EventDB.Instance.events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventID).
            getSelections().Find(s => s.getSelectionNum() == 1).getAction().startAction();
    }
    public void selectionClick2()
    {
        EventDB.Instance.events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventID).
            getSelections().Find(s => s.getSelectionNum() == 2).getAction().startAction();
    }
    public void selectionClick3()
    {
        EventDB.Instance.events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventID).
            getSelections().Find(s => s.getSelectionNum() == 3).getAction().startAction();
    }
    public void selectionClick4()
    {
        EventDB.Instance.events.Find(x => x.getEventName() == EventManager.Instance.currentEventName && x.getEventID() == EventManager.Instance.currentEventID).
            getSelections().Find(s => s.getSelectionNum() == 4).getAction().startAction();
    }
}
