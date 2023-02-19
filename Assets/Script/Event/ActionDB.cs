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
    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
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
