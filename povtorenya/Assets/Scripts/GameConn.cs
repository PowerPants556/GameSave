using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameConn : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel, gamePanel;
    public Text startText;
    [SerializeField]
    private Text scoreText, bestScore;
    public int score;


    private void Start()
    {
        score = 0;
        pausePanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void BackToManu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void SwitchPause()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
        gamePanel.SetPanel(!gamePanel.activeSelf);

        switch (Time.timeScale)
        {
            case 1:
                Time.timeScale = 0;
                break;
            case 0:
                Time.timeScale = 1;
                break;
            default:
                break;
        }

    }
}
