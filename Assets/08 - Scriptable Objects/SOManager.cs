using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SOManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;

    private void Start()
    {
        WeaponSO[] weapons = Resources.LoadAll<WeaponSO>("Weapons");

        for (int i = 0; i < weapons.Length; i++)
        {
            Text.text += $"{weapons[i].Name}\n";
        }

        GameObject weaponPrefab = Resources.Load<GameObject>(weapons[0].PrefabPath);
        Instantiate(weaponPrefab);
    }
}
