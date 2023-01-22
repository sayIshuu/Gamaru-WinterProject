using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeUIManager : MonoBehaviour
{
    [SerializeField] GameObject RecipePanel;

    public void BackToMain()
    {
        RecipePanel.SetActive(false);
    }
}
