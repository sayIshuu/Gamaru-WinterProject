using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//�̺�Ʈ db���� �̺�Ʈ ������ �����ͼ�
//�Լ��� ���� ui������ �ѷ��ش�.
//������ ��Ŭ������.
public class EventManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textMeshPro;

    //private EventDB eventDB;
    private void Start()
    {
        EventDB.currentEventName = "Ʃ�丮��";
        EventDB.currentEventNameID = 1;
        //EventDB.eventArray
        //��������ư ������ �����ִ� �Լ� �����´�.
        //eventStart(eventDB.events.Find(x => x.getEventName() == "Ʃ�丮��" && x.getEventID() == 1));
        textMeshPro.text = "����.";
    }

    // �̺�Ʈ �ߵ�
    public void eventStart(Event newEvent) 
    {
        // �̺�Ʈ ������.. ���⿡ ���� eventName, eventID���� ����Ǿ�����.
        Event currentEvent = newEvent.getThisEvent();

        // �̺�Ʈ �ؽ�Ʈ ��ü
        textMeshPro.text = currentEvent.getEventText();

        // selectionUI �� selection ��ü �Ѹ���
        // selectionUpdate �̿�!!
    }
    //onClick�� �ΰ� �Լ� ����. �׼ǽ����̶� �ؽ�Ʈ�Ѹ��°�..�ƴϸ� �׼ǽ��࿡ �� eventStart�Լ��� �־�ֵ� ����.
}
