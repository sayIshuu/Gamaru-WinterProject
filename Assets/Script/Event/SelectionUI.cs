using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionUI : MonoBehaviour
{
    private static SelectionUI instance = null;

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
    public static SelectionUI Instance
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

    public GameObject selSlot_1, selSlot_2, selSlot_3, selSlot_4;


    private Action action;

    public void selectionSetting()
    {
        selSlot_1.SetActive(false);
        selSlot_2.SetActive(false);
        selSlot_3.SetActive(false);
        selSlot_4.SetActive(false);
    }


    // 선택지 업데이트 함수
    public void selectionUpdate(Selection changedSelection)
    {
        if(changedSelection.getSelectionNum() == 1)
        {
            selSlot_1.SetActive(true);
            selSlot_1.GetComponentInChildren<TextMeshProUGUI>().text = changedSelection.getText();
        }
        else if(changedSelection.getSelectionNum() == 2)
        {
            selSlot_2.SetActive(true);
            selSlot_2.GetComponentInChildren<TextMeshProUGUI>().text = changedSelection.getText();
        }
        else if (changedSelection.getSelectionNum() == 3)
        {
            selSlot_3.SetActive(true);
            selSlot_3.GetComponentInChildren<TextMeshProUGUI>().text = changedSelection.getText();
        }
        else if (changedSelection.getSelectionNum() == 4)
        {
            selSlot_4.SetActive(true);
            selSlot_4.GetComponentInChildren<TextMeshProUGUI>().text = changedSelection.getText();
        }

        // 해당 선택지에 맞는 액션 세팅
        action.setAction(changedSelection.getAction());
    }
}
