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

    // ������ ������Ʈ �Լ�
    private void selectionUpdate(Selection changedSelection)
    {
        selection = changedSelection;
        
        // �ؽ�Ʈ ����
        textMeshPro.text = selection.getText();

        // �ش� �������� �´� �׼� ����
        action.setAction(changedSelection.getAction());
    }
}
