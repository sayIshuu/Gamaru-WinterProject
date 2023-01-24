using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeUIManager : MonoBehaviour
{
    [SerializeField] GameObject RecipePanel;

    public Inventory_Slot[] inventory_Slots;
    public Transform slotHolder;

    public void BackToMain()
    {
        RecipePanel.SetActive(false);
    }

    private void Start()
    {
        inventory_Slots = slotHolder.GetComponentsInChildren<Inventory_Slot>();

    }
}
