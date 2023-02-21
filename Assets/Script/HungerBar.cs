using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 포만감 감소 함수호출or세터 호출할때 능력치나 시간변수따라서 감소 되게끔.
// 그러고 이벤트 끝날때마다 호출. 시간변수나 능력치는 받아와야함 각각의 이벤트 객체에서.
// 각각의 이벤트 객체는 소주제로 나눈다.

public class HungerBar : MonoBehaviour
{
    private static HungerBar instance = null;
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
    public static HungerBar Instance
    {
        get
        {
            if (null == instance)
                return null;
            return instance;
        }
    }


    [SerializeField] private Slider hungerBar;
    [SerializeField]
    private float maxHunger, curHunger;


    //이벤트 끝날때 배고픔 감소하는 함수. 이벤트로부터 시간변수 받아오고, 주인공 스탯에서 능력치변수 받아와야함.
    public void HungerDown(float time /*, 능력치를 어떻게 넣지*/)
    {
        float downAmount = (float)time/*-능력치*/;
        curHunger -= downAmount;

        //자연스럽게 줄어들게.
        //hungerBar.value = Mathf.Lerp( hungerBar.value, (float)curHunger / (float)maxHunger, Time.deltaTime*10);
        hungerBar.value = (float)curHunger / (float)maxHunger;
        if (curHunger < 0)
            curHunger = 0;
    }

    //오버로딩 가능성도 생각.
    public void HungerUp(float calroli)
    {
        float upAmount = (float)calroli;
        curHunger += upAmount;

        //hungerBar.value = Mathf.Lerp(hungerBar.value, (float)curHunger / (float)maxHunger, Time.deltaTime * 10);
        hungerBar.value = (float)curHunger / (float)maxHunger;
        if (curHunger > 100)
            curHunger = 100;
    }


    //나중에 현재포만감/최대포만감 해서 value값 연결시키면 됨.
    void Start()
    {
        hungerBar.value = ((float)curHunger) / (float)maxHunger;
        Debug.Log(hungerBar.value);
    }

}
