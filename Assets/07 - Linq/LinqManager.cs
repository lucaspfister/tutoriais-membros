using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;

public class LinqManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private PlayerData[] Players;

    private void Start()
    {
        var sum = Players.Where(p => p.Age >= 40).Sum(p => p.Points);
        Text.text = sum.ToString();
    }

    private void DisplayPlayersOrderByName()
    {
        var list = Players
            .OrderBy(p => p.Name)
            .ToList();

        for (int i = 0; i < list.Count; i++)
        {
            Text.text += $"{list[i].Name}\n";
        }
    }

    private void DisplayHigherPoints()
    {
        var list = Players
            .OrderByDescending(p => p.Points)
            .Select(p => $"{p.Name}: {p.Points}")
            .ToList();

        for (int i = 0; i < list.Count; i++)
        {
            Text.text += $"{list[i]}\n";
        }
    }

    private void DisplayTop3()
    {
        var list = Players
            .Where(p => p.Age >= 18)
            .OrderByDescending(p => p.Points)
            .Take(3)
            .Select(p => $"{p.Name}: {p.Points} - Age: {p.Age}")
            .ToList();

        for (int i = 0; i < list.Count; i++)
        {
            Text.text += $"{i + 1}º - {list[i]}\n";
        }
    }
}

[Serializable]
public struct PlayerData
{
    public string Name;
    public int Age;
    public int Points;
}
