using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainUIManager : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;

    public void LoadSettingPanel()
    {
        SettingPanel.SetActive(true);
    }
}
