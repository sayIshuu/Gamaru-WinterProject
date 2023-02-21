using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecipeUIManager : MonoBehaviour
{
    private static RecipeUIManager instance = null;
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
    public static RecipeUIManager Instance
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


    [SerializeField] GameObject RecipePanel;
    [SerializeField] GameObject ingredientPrefab;
    [SerializeField] GameObject ingredientContent;

    //public Inventory_Slot[] inventory_Slots;
    //public Transform slotHolder;

    public Dictionary<string, int> ingredientDB = new Dictionary<string, int>();
    




    public void BackToMain()
    {
        RecipePanel.SetActive(false);
        //Instantiate(ingredientPrefab, ingredientContent.transform);
    }


    private void Start()
    {
        //inventory_Slots = slotHolder.GetComponentsInChildren<Inventory_Slot>();
        
    }
}
