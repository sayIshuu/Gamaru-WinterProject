using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainUIManager : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;
    [SerializeField] GameObject IssuePanel;
    [SerializeField] GameObject StatePanel;
    [SerializeField] GameObject RecipePanel;


    public void LoadSettingPanel()
    {
        SettingPanel.SetActive(true);
    }

    public void LoadIssuePanel()
    {
        IssueUIManager.Instance.setIssues();
        IssuePanel.SetActive(true);
    }

    public void LoadStatePanel()
    {
        StatePanel.SetActive(true);
    }

    public void LoadRecipePanel()
    {
        RecipeUIManager.Instance.setIngredient();
        RecipePanel.SetActive(true);
    }
}
