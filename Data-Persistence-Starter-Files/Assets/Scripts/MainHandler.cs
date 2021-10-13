using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHandler : MonoBehaviour
{
    string statusBar;
    // Start is called before the first frame update
    void Start()
    {
        if(MenuManager.Instance != null)
        {
            MenuManager.Instance.playerScore = 0;
            statusBar = "Best Score: " + MenuManager.Instance.highScore + " Name: " + MenuManager.Instance.highScoreName;
            transform.Find("HighScoreText").GetComponent<Text>().text = statusBar;
        }
    }

    private void Update()
    {
        if (MenuManager.Instance.playerScore > MenuManager.Instance.highScore)
        {
            MenuManager.Instance.highScore = MenuManager.Instance.playerScore;
            MenuManager.Instance.highScoreName = MenuManager.Instance.playerName;
            statusBar = "Best Score: " + MenuManager.Instance.highScore + " Name: " + MenuManager.Instance.highScoreName;
            transform.Find("HighScoreText").GetComponent<Text>().text = statusBar;
            MenuManager.Instance.SaveHighScore();
        }
    }
}
