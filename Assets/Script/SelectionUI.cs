using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionUI : MonoBehaviour
{
    private Selection selection;
    [SerializeField]
    private TMP_Text textMeshPro;

    private Action action;

    // 선택지 업데이트 함수
    private void selectionUpdate(Selection changedSelection)
    {
        selection = changedSelection;
        
        // 텍스트 갱신
        textMeshPro.text = selection.getText();

        // 해당 선택지에 맞는 액션 세팅
        action.setAction(changedSelection.getAction());
    }
}
