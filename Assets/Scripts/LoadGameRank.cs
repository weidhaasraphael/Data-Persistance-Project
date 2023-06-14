using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class LoadGameRank : MonoBehaviour
{
    public Text BestPlayerName;

    private static int bestScore;
    private static string bestPlayer;

    private void Awake()
    {
        LoadRank();
    }

    private void setBestPlayer()
    {
        if(bestPlayer == null && bestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = "Best Score: " + bestScore + " from " + bestPlayer;
        }
    }

    public void LoadRank()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = data.TheBestPlayer;
            bestScore = data.HighestScore;
            setBestPlayer();
        }
        else
        {
            Debug.Log("Cannot find file!");
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int HighestScore;
        public string TheBestPlayer;
    }
}
