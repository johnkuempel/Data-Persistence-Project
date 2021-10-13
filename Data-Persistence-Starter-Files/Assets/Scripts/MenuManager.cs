using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public string playerName;
    public string highScoreName;
    public int playerScore;
    public int highScore;
    public static MenuManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerName(string input)
    {
        Debug.Log("test" + input);
        playerName = input;
    }

    [System.Serializable]
    class SaveData
    {
        public string highScoreName;
        public int highScore;
    }
    public void SaveHighScore()
    {
        SaveData highScoreRecord = new SaveData();
        highScoreRecord.highScoreName = highScoreName;
        highScoreRecord.highScore = highScore;

        string json = JsonUtility.ToJson(highScoreRecord);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData highScoreRecord = JsonUtility.FromJson<SaveData>(json);

            highScore = highScoreRecord.highScore;
            highScoreName = highScoreRecord.highScoreName;
        }
    }
    
}
