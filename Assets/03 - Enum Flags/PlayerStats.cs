using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Flags]
public enum Stat
{
    None = 0,
    Stunned = 1,
    Poisoned = 2,
    Burned = 4,
    Paralyzed = 8,
    Dead = 16
}

public class PlayerStats
{
    private Stat Stat;

    public bool HasStat(Stat stat)
    {
        return Stat.HasFlag(stat);
    }

    public void ApplyStat(Stat stat)
    {
        Stat |= stat;
    }

    public void RemoveStat(Stat stat)
    {
        Stat &= ~stat;
    }

    public override string ToString()
    {
        return Stat.ToString();
    }
}
