using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumFlagsManager : MonoBehaviour
{
    private void Start()
    {
        PlayerStats playerStats = new ();

        playerStats.ApplyStat(Stat.Stunned);
        playerStats.ApplyStat(Stat.Poisoned);
        playerStats.ApplyStat(Stat.Paralyzed);
        playerStats.ApplyStat(Stat.Burned);

        playerStats.RemoveStat(Stat.Poisoned);

        Debug.Log(playerStats.ToString());
    }
}
