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
    [SerializeField]
    private TMP_Text textMeshPro;

    //private EventDB eventDB;
    private void Start()
    {
        EventDB.currentEventName = "튜토리얼";
        EventDB.currentEventNameID = 1;
        //EventDB.eventArray
        //선택지버튼 누르면 여기있는 함수 가져온다.
        //eventStart(eventDB.events.Find(x => x.getEventName() == "튜토리얼" && x.getEventID() == 1));
        textMeshPro.text = "떠라.";
    }

    // 이벤트 발동
    public void eventStart(Event newEvent) 
    {
        // 이벤트 가져옴.. 여기에 현재 eventName, eventID정보 저장되어있음.
        Event currentEvent = newEvent.getThisEvent();

        // 이벤트 텍스트 교체
        textMeshPro.text = currentEvent.getEventText();

        // selectionUI 에 selection 객체 뿌리기
        // selectionUpdate 이용!!
    }
    //onClick에 두개 함수 연결. 액션실행이랑 텍스트뿌리는거..아니면 액션실행에 이 eventStart함수를 넣어둬도 괜찮.
}
