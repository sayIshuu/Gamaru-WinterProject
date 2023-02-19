using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    private static HeartManager instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);
    }
    //게임 매니저 인스턴스에 접근할 수 있는 프로퍼티. static이므로 다른 클래스에서 맘껏 호출할 수 있다.
    public static HeartManager Instance
    {
        get
        {
            if (null == instance)
                return null;
            return instance;
        }
    }

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

