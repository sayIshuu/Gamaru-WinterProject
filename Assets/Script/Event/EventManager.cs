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
            currentEventName = "튜토리얼";
            currentEventID = 1;
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
    public int currentEventID;

    // 이벤트 발동
    public void eventStart(Event newEvent)
    {
        subjectText.text = newEvent.getEventName();
        // 이벤트 텍스트 교체
        mainText.text = newEvent.getEventText();

        // selectionUI 에 selection 객체 뿌리기
        // selectionUpdate 이용!!
        SelectionUI.Instance.selectionSetting();
        foreach(Selection selection in newEvent.getSelections())
        {
            SelectionUI.Instance.selectionUpdate(selection);
        }
    }
}
