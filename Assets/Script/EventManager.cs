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

    private void Start()
    {
        //EventDB.eventArray
        //선택지버튼 누르면 여기있는 함수 가져온다.
        // eventStart(튜토리얼 이벤트 객체);
    }

    // 이벤트 발동
    private void eventStart(Event newEvent) {
        // 이벤트 가져옴
        Event currentEvent = newEvent.getThisEvent();

        // 이벤트 텍스트 교체
        textMeshPro.text = currentEvent.getEventText();

        // selectionUI 에 selection 객체 뿌리기
        // selectionUpdate 이용!!
    }
}
