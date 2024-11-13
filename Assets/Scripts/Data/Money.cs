using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Money", menuName = "Money")]
public class Money : ScriptableObject
{
    [Header("Money")] 
    public int money;
}
