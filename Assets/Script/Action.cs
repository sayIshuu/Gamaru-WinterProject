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
        // 이전 선택지의 델리게이트랑 매개변수 초기화
        actionDelegates.Clear();
        paramList.Clear();

        // 다음 실행시킬 이벤트 이름과 아이디 세팅
        nextEventName = action.nextEventName;
        nextEventId = action.nextEventId;

        // 액션 템플릿 리스트 가져옴
        actionTempletes = action.actionTempletes;
        // 액션 템플릿들의 정보를 실제 델리게이트와 매개변수 리스트에 넣어준다.
        foreach(ActionTemplete actionTemplete in actionTempletes)
        {
            // 인스팩터에서 넣은 액션의 이름과 수치를 델리게이트 리스트(actionDelegates)에 넣는다.
            ActionDelegate actionAction = ActionDB.getActionDelegate(actionTemplete.actionName);
            actionDelegates.Add(actionAction);
            paramList.Add(actionTemplete.actionParam);
        }
    }

    public Action getAction()
    {
        return this;
    }

    // onClick 연결 함수
    public void startAction()
    {
        for(int i = 0; i < actionDelegates.Count; i++)
        {
            ActionDelegate actionDelegate = actionDelegates[i];
            actionDelegate(paramList[i]);
        }
        // 이벤트 이동
        // nextEventName이랑 ID를 이용해서 ㄲ
    }
}

// EventDB에 값 채워넣기
// onclick연결
// 선택지 개수에따라 활성화
