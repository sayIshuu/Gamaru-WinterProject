using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// ������ ���� �Լ�ȣ��or���� ȣ���Ҷ� �ɷ�ġ�� �ð��������� ���� �ǰԲ�.
// �׷��� �̺�Ʈ ���������� ȣ��. �ð������� �ɷ�ġ�� �޾ƿ;��� ������ �̺�Ʈ ��ü����.
// ������ �̺�Ʈ ��ü�� �������� ������.

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
    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
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


    //�̺�Ʈ ������ ����� �����ϴ� �Լ�. �̺�Ʈ�κ��� �ð����� �޾ƿ���, ���ΰ� ���ȿ��� �ɷ�ġ���� �޾ƿ;���.
    public void HungerDown(float time /*, �ɷ�ġ�� ��� ����*/)
    {
        float downAmount = (float)time/*-�ɷ�ġ*/;
        curHunger -= downAmount;

        //�ڿ������� �پ���.
        //hungerBar.value = Mathf.Lerp( hungerBar.value, (float)curHunger / (float)maxHunger, Time.deltaTime*10);
        hungerBar.value = (float)curHunger / (float)maxHunger;
        if (curHunger < 0)
            curHunger = 0;
    }

    //�����ε� ���ɼ��� ����.
    public void HungerUp(float calroli)
    {
        float upAmount = (float)calroli;
        curHunger += upAmount;

        //hungerBar.value = Mathf.Lerp(hungerBar.value, (float)curHunger / (float)maxHunger, Time.deltaTime * 10);
        hungerBar.value = (float)curHunger / (float)maxHunger;
        if (curHunger > 100)
            curHunger = 100;
    }


    //���߿� ����������/�ִ������� �ؼ� value�� �����Ű�� ��.
    void Start()
    {
        hungerBar.value = ((float)curHunger) / (float)maxHunger;
        Debug.Log(hungerBar.value);
    }

}
