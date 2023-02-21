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

    //��Ŵ� �ִ� 100
    private void useCalroli(string calroli)
    {
        HungerBar.Instance.HungerDown(float.Parse(calroli));
    }
    private void eat(string calroli)
    {
        HungerBar.Instance.HungerUp(float.Parse(calroli));
    }

    private void hpChange(string hp)
    {
        HeartManager.Instance.Heart += int.Parse(hp);
    }

    private void maxHpChange(string hp)
    {
        HeartManager.Instance.Max_Heart += int.Parse(hp);
    }
    
    private void addItem(string itemAndnum)
    {
        string[] result = itemAndnum.Split(new char[] { 'X' });
        if (RecipeUIManager.Instance.ingredientDB.ContainsKey(result[0]))
        {
            RecipeUIManager.Instance.ingredientDB[result[0]] += int.Parse(result[1]);
        }
        else
        {
            RecipeUIManager.Instance.ingredientDB.Add(result[0], int.Parse(result[1]));
        }
    }
    private void useItem(string itemAndnum)
    {
        string[] result = itemAndnum.Split(new char[] { 'X' });
        RecipeUIManager.Instance.ingredientDB[result[0]] -= int.Parse(result[1]);
        if (RecipeUIManager.Instance.ingredientDB[result[0]] == 0)
        {
            RecipeUIManager.Instance.ingredientDB.Remove(result[0]);
        }
    }

    private void getIssue(string issue)
    {
        IssueUIManager.Instance.issues.Add(issue);
    }
    private void loseIssue(string issue)
    {
        IssueUIManager.Instance.issues.Remove(issue);
    }


    void Start()
    {
        actionDB.Add("maxHpChange", maxHpChange);
        actionDB.Add("hpChange", hpChange);
        actionDB.Add("eat", eat);
        actionDB.Add("useCalroli", useCalroli);
        actionDB.Add("addItem", addItem);
        addItem("�̼�������X2");
        addItem("�̼��ξ�����X1");
        getIssue("�������Ѽ���");
        getIssue("�̼��� ��ģ");
    }

    public ActionDelegate getActionDelegate(string actionName)
    {
        return actionDB[actionName];
    }
}
