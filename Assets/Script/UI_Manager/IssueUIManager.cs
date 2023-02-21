using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IssueUIManager : MonoBehaviour
{
    private static IssueUIManager instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
    public static IssueUIManager Instance
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


    [SerializeField] GameObject IssuePanel;
    [SerializeField] GameObject issuePrefab;
    [SerializeField] GameObject issueContent;


    public List<string> issues = new List<string>();

    List<GameObject> newobj = new List<GameObject>();
    public void setIssues()
    {
        foreach (var issue in issues)
        {
            GameObject temp = Instantiate(issuePrefab, issueContent.transform);
            temp.GetComponentInChildren<TextMeshProUGUI>().text = issue;
            newobj.Add(temp);
        }
    }

    public void BackToMainUI()
    {
        IssuePanel.SetActive(false);
        foreach (var ingredient in newobj)
        {
            Destroy(ingredient);
        }
    }
}
