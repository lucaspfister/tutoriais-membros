using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/Weapon", order = 0)]
public class WeaponSO : ScriptableObject
{
    public string Name;
    public string PrefabPath;

    [Space]
    [Header("Gameplay")]
    public float Damage;
    [Tooltip("Quantidade de muni��o inicial")]
    public int AmmoAmount;

    [Space, Header("Prices")]
    [Tooltip("Pre�o da arma na loja")]
    public float Price;
    [Tooltip("Pre�o unit�rio da muni��o")]
    public float AmmoPrice;
}
