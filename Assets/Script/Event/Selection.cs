using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Selection
{
    [SerializeField]
    private string text;
    [SerializeField]
    private int selectionNum;
    [SerializeField]
    private Action action;

    public string getText()
    {
        return text;
    }

    public int getSelectionNum()
    {
        return selectionNum;
    }

    public Action getAction()
    {
        return action;
    }
}
