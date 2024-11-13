using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revenue : MonoBehaviour, MousePointEnter
{
    public PlayerStateData state;
    public Money moneySO;
    
    public Text revenueText;
    
    private float time;
    public int money;

    private void Start()
    {
        money = moneySO.money;
    }

    private void Update()
    {
        time += Time.deltaTime;
        AutoRevenue();
        revenueText.text = $"보유한 돈은 : {money.ToString()} 원";
    }

    public void OnClickRevenue()
    {
        Debug.Log($"OnClickRevenue 돈총량은 : {money}");
        Debug.Log($"OnClickRevenue 데미지 값은 : {state.damage}");
        money += state.damage;
        time = 0;
    }

    public void AutoRevenue()
    {
        if (time >= 2f)
        {
            OnClickRevenue();
        }
    }

    public void OnPointEnter()
    {
        Debug.Log("0000");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("1111");
            OnClickRevenue();
        }
    }
}
