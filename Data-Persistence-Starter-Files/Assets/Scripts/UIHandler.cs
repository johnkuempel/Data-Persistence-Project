using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    //public Text inputText;
    //public GameObject inputField;
    // Start is called before the first frame update
    void Start()
    {
        
       // Input.onEndEdit.AddListener(PlayerName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayerName(string input)
    {
        //string damn = input.GetComponent<Text>().GetComponent<Text>().text;
        //MainManager.Instance.playerName = name;
        Debug.Log("test" + input);
        MenuManager.Instance.playerName = input;
        //Debug.Log(name);
    }
}
