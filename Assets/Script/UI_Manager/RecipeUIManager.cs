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


    public Dictionary<string, int> ingredientDB = new Dictionary<string, int>();

    List<GameObject> newobj = new List<GameObject>();
    public void setIngredient()
    {
        foreach (var ingredient in ingredientDB)
        {
            GameObject temp = Instantiate(ingredientPrefab, ingredientContent.transform);
            temp.GetComponentInChildren<TextMeshProUGUI>().text = ingredient.Key + ingredient.Value.ToString();
            newobj.Add(temp);
        }
    }


    public void BackToMain()
    {
        RecipePanel.SetActive(false);
        foreach(var ingredient in newobj)
        {
            Destroy(ingredient);
        }
    }
}
