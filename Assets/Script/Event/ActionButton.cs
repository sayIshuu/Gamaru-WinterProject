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
}
