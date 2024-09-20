using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class JsonManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private GameData GameData;

    string DataPath;

    private void Start()
    {
        DataPath = $"{Application.persistentDataPath}/gameData.json";

        GameData = LoadJsonFromDisk(DataPath);
    }

    private void SaveJsonToDisk(string path, GameData gameData)
    {
        string json = JsonUtility.ToJson(gameData);
        File.WriteAllText(path, json);
    }

    private GameData LoadJsonFromDisk(string path)
    {
        if (!File.Exists(path)) return null;

        string json = File.ReadAllText(path);
        GameData gameData = JsonUtility.FromJson<GameData>(json);
        return gameData;
    }

    private void OnDestroy()
    {
        SaveJsonToDisk(DataPath, GameData);
    }
}

[Serializable]
public class GameData
{
    public int Number;
    public PlayerData[] Players;
}