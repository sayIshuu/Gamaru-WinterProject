using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//이벤트 db에서 이벤트 정보들 가져와서
//함수를 통해 ui들한테 뿌려준다.
//실행은 온클릭에서.
public class EventManager : MonoBehaviour
{
    private static EventManager instance = null;

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
    public int currentEventNameID;

    //private EventDB eventDB;
    private void Start()
    {
        currentEventName = "튜토리얼";
        currentEventNameID = 1;
        //EventDB.eventArray
        //선택지버튼 누르면 여기있는 함수 가져온다.
        //eventStart(eventDB.events.Find(x => x.getEventName() == "튜토리얼" && x.getEventID() == 1));
    }

    // 이벤트 발동
    public void eventStart(Event newEvent)
    {
        // 이벤트 가져옴.. 여기에 현재 eventName, eventID정보 저장되어있음.
        //Event currentEvent = newEvent.getThisEvent();

        subjectText.text = newEvent.getEventName();
        // 이벤트 텍스트 교체
        mainText.text = newEvent.getEventText();

        // selectionUI 에 selection 객체 뿌리기
        // selectionUpdate 이용!!
        foreach(Selection selection in newEvent.getSelections())
        {
            SelectionUI.Instance.selectionUpdate(selection);
        }

    }
    //onClick에 두개 함수 연결. 액션실행이랑 텍스트뿌리는거..아니면 액션실행에 이 eventStart함수를 넣어둬도 괜찮.
}
