using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite isFill;
    [SerializeField] Sprite isEmpty;
    [SerializeField] int startHP, startMaxHP;
    

    private int heart;
    //Heart�� ���ΰ��� hp�� heart�� ����, set�Ӽ����� ���� Update�Լ� �Ⱦ���.
    public int Heart
    {
        get { return heart; }
        set
        {
            heart = value;
            for (int i = 0; i < hearts.Length; i++)
            {
                //����Ʈ��, ����Ʈ��
                if (i < heart)
                {
                    hearts[i].sprite = isFill;
                }
                else
                {
                    hearts[i].sprite = isEmpty;
                }

                //��Ʈ�� �ƿ� ǥ������ ����..
                if (i < max_heart)
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


    private int max_heart;
    public int Max_Heart
    {
        get { return max_heart; }
        set
        {
            max_heart = value;
        }
    }



    private void Start()
    {
        Max_Heart = startMaxHP;
        Heart = startHP;
    }
}

