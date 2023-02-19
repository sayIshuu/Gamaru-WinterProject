using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ActionDelegate(string param);

public class ActionDB : MonoBehaviour
{
    private static ActionDB instance = null;
    void Awake()
    {
        if (null == instance)
        {
            actionDB = new Dictionary<string, ActionDelegate>();
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //게임 매니저 인스턴스에 접근할 수 있는 프로퍼티. static이므로 다른 클래스에서 맘껏 호출할 수 있다.
    public static ActionDB Instance
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


    private Dictionary<string, ActionDelegate> actionDB;

    private void moneyChange(string money)
    {
        print(money);
    }

    private void hpChange(string hp)
    {
        HeartManager.Instance.Heart += int.Parse(hp);
    }

    private void maxHpChange(string hp)
    {
        HeartManager.Instance.Max_Heart += int.Parse(hp);
    }

    void Start()
    {
        actionDB.Add("maxHpChange", maxHpChange);
        actionDB.Add("hpChange", hpChange);
    }

    public ActionDelegate getActionDelegate(string actionName)
    {
        return actionDB[actionName];
    }
}
