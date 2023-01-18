using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IssueUIManager : MonoBehaviour
{
    [SerializeField] GameObject IssuePanel;

    public void LoadIssuePanel()
    {
        IssuePanel.SetActive(true);
    }
}
