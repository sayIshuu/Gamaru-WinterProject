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
    //Heart로 주인공의 hp인 heart를 조절, set속성으로 굳이 Update함수 안쓴다.
    public int Heart
    {
        get { return heart; }
        set
        {
            heart = value;
            for (int i = 0; i < hearts.Length; i++)
            {
                //빈하트냐, 찬하트냐
                if (i < heart)
                {
                    hearts[i].sprite = isFill;
                }
                else
                {
                    hearts[i].sprite = isEmpty;
                }

                //하트를 아예 표시할지 말지..
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

