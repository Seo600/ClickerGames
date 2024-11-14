using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revenue : MonoBehaviour, MousePointEnter
{
    public PlayerStateData state;
    public Money moneySO;
    
    public Text revenueText;
    public Text attackText;
    public Text clickerRevenueText;
    
    private float time;
    public int money;

    private void Start()
    {
        money = moneySO.money;
        AttackDamage();
    }

    private void Update()
    {
        time += Time.deltaTime;
        AutoRevenue();
        OnPointEnter();
        revenueText.text = $"보유한 돈은 : {money.ToString()} 원";
        OnClickTime();
    }

    public void OnClickRevenue()
    {
        money += state.damage;
        time = 0;
        clickerRevenueText.text = $"+ {state.damage.ToString()} 원";
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
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetMouseButtonDown(0))
        {
            OnClickRevenue();
        }
    }

    public void OnClickTime()
    {
        if (time > 0.2f)
        {
            clickerRevenueText.text = "";
        }
    }

    public void AttackDamage()
    {
        attackText.text = state.damage.ToString();
    }
}
