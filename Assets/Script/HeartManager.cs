using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] int Heart;
    [SerializeField] int MaxHeart;

    [SerializeField] Image[] hearts;
    [SerializeField] Sprite isFull;
    [SerializeField] Sprite isEmpty;

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < Heart)
            {
                hearts[i].sprite = isFull;
            }
            else
            {
                hearts[i].sprite = isEmpty;
            }

            if (i < MaxHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}

