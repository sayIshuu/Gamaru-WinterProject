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
    private static EventManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            currentEventName = "Ʃ�丮��";
            currentEventID = 1;
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
    public static EventManager Instance
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



    [SerializeField]
    private TMP_Text mainText;
    [SerializeField]
    private TMP_Text subjectText;

    public string currentEventName;
    public int currentEventID;

    //private EventDB eventDB;
    private void Start()
    {
        //EventDB.eventArray
        //��������ư ������ �����ִ� �Լ� �����´�.
        //eventStart(eventDB.events.Find(x => x.getEventName() == "Ʃ�丮��" && x.getEventID() == 1));
    }

    // �̺�Ʈ �ߵ�
    public void eventStart(Event newEvent)
    {
        subjectText.text = newEvent.getEventName();
        // �̺�Ʈ �ؽ�Ʈ ��ü
        mainText.text = newEvent.getEventText();

        // selectionUI �� selection ��ü �Ѹ���
        // selectionUpdate �̿�!!
        SelectionUI.Instance.selectionSetting();
        foreach(Selection selection in newEvent.getSelections())
        {
            SelectionUI.Instance.selectionUpdate(selection);
        }
    }
}
