using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revenue : MonoBehaviour
{
    public PlayerStateData state;
    public Money money;
    
    public Text revenueText;
    
    private float time;

    private void Start()
    {
        time = Time.time;
    }

    private void Update()
    {
        AutoRevenue();
        revenueText.text = money.money.ToString();
    }

    public void ClickRevenue()
    {
        money.money += state.damage;
        time = 0;
    }

    public void AutoRevenue()
    {
        if (time >= 2f)
        {
            ClickRevenue();
        }
    }
}
