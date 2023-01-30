using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionTemplete
{
    public string actionName;
    public string actionParam;
    public ActionTemplete(string _actionName, string _actionParam)
    {
        actionName = _actionName;
        actionParam = _actionParam;
    }
}

[System.Serializable]
public class Action
{
    public string nextEventName;

    public int nextEventId;

    public List<ActionTemplete> actionTempletes;

    private List<ActionDelegate> actionDelegates = new List<ActionDelegate>();

    private List<string> paramList;

    public void setAction(Action action)
    {
        // ���� �������� ��������Ʈ�� �Ű����� �ʱ�ȭ
        actionDelegates.Clear();
        paramList.Clear();

        // ���� �����ų �̺�Ʈ �̸��� ���̵� ����
        nextEventName = action.nextEventName;
        nextEventId = action.nextEventId;

        // �׼� ���ø� ����Ʈ ������
        actionTempletes = action.actionTempletes;
        // �׼� ���ø����� ������ ���� ��������Ʈ�� �Ű����� ����Ʈ�� �־��ش�.
        foreach(ActionTemplete actionTemplete in actionTempletes)
        {
            // �ν����Ϳ��� ���� �׼��� �̸��� ��ġ�� ��������Ʈ ����Ʈ(actionDelegates)�� �ִ´�.
            ActionDelegate actionAction = ActionDB.getActionDelegate(actionTemplete.actionName);
            actionDelegates.Add(actionAction);
            paramList.Add(actionTemplete.actionParam);
        }
    }

    public Action getAction()
    {
        return this;
    }

    // onClick ���� �Լ�
    public void startAction()
    {
        for(int i = 0; i < actionDelegates.Count; i++)
        {
            ActionDelegate actionDelegate = actionDelegates[i];
            actionDelegate(paramList[i]);
        }
        // �̺�Ʈ �̵�
        // nextEventName�̶� ID�� �̿��ؼ� ��
    }
}

// EventDB�� �� ä���ֱ�
// onclick����
// ������ ���������� Ȱ��ȭ
