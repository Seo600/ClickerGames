using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStateData", menuName = "Player State")]
public class PlayerStateData : ScriptableObject
{
    [Header("State")] 
    public int damage;
}
