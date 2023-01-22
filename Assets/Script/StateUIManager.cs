using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateUIManager : MonoBehaviour
{
    [SerializeField] GameObject StatePanel;

    public void BackToMain()
    {
        StatePanel.SetActive(false);
    }
}
