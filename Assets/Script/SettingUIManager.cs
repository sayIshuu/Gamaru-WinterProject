using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUIManager : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;

    public void BackToMainUI()
    {
        SettingPanel.SetActive(false);
    }
}
