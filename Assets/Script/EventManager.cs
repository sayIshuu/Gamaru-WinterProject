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

    private void Start()
    {
        //EventDB.eventArray
        //��������ư ������ �����ִ� �Լ� �����´�.
        // eventStart(Ʃ�丮�� �̺�Ʈ ��ü);
    }

    // �̺�Ʈ �ߵ�
    private void eventStart(Event newEvent) {
        // �̺�Ʈ ������
        Event currentEvent = newEvent.getThisEvent();

        // �̺�Ʈ �ؽ�Ʈ ��ü
        textMeshPro.text = currentEvent.getEventText();

        // selectionUI �� selection ��ü �Ѹ���
        // selectionUpdate �̿�!!
    }
}
