using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuConn : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPanel, optionsPanel;
    [SerializeField]
    private Text bestScoreText;
    [SerializeField]
    private Slider volumeSlider;
    public static int colorNum, bestScore;

    private enum Colors
    {
        WHITE = 1,
        YELLOW = 2,
        GREEN = 3
    }


    void Start()
    {
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        colorNum = PlayerPrefs.GetInt("Color", 1);
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        bestScoreText.text = "Best Score: " + bestScore.ToString();
        AudioListener.volume = volumeSlider.value;
    }
    public void SetColor(string colorSpriteName)
    {
        switch(colorSpriteName)
        {
            case "WHITE":
                colorNum = (int)Colors.WHITE;
                break;
            case "YELLOW":
                colorNum = (int)Colors.YELLOW;
                break;
            case "GREEN":
                colorNum = (int)Colors.GREEN;
                break;
        }
        PlayerPrefs.SetInt("ColorNum", colorNum);
    }
    public void OpenGameLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SwitchOptions()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
        optionsPanel.SetActive(!optionsPanel.activeSelf);
        PlayerPrefs.SetFloat("Volume",volumeSlider.value);
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
        bestScore = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

