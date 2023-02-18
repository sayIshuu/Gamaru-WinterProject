using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ActionDelegate(string param);

public class ActionDB : MonoBehaviour
{
    
    private static Dictionary<string, ActionDelegate> actionDB = new Dictionary<string, ActionDelegate>();

    void Start()
    {
        actionDB.Add(nameof(moneyChange), moneyChange);
        actionDB.Add(nameof(hpChange), hpChange);
    }

    private void moneyChange(string money)
    {
        print(money);
    }

    private void hpChange(string hp)
    {
        Debug.Log(hp);
    }

    public static ActionDelegate getActionDelegate(string actionName)
    {
        ActionDelegate actionDelegate;
        actionDB.TryGetValue(actionName, out actionDelegate);
        return actionDelegate;
    }
}
