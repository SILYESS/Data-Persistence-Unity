using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TMP_InputField playerName;
    public Button startButton;
    public Button quitButton;
    public int score;
    public string inputText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputText = playerName.text;
        MenuManager.instance.playerName = inputText;
        scoreText.text = "Best Score: " + inputText + ": " + score;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
}
