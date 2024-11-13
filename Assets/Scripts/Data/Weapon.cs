using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "WeaponData")]
public class Weapon : ScriptableObject
{
    public string name;
    public int damage;
    public int price;
}
