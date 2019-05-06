using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : UIScreen
{
    public GameObject pausePanel;
    public GameObject lowerBtnPanel;
    public GameObject pauseBtn;

    protected ScoreController sc;
    protected Text[] texts;
    void Start() {
        Initialize();
        texts = GetComponentsInChildren<Text>();
        sc.PlayGame();

    }

    void Update() {
        foreach (Text text in texts)
        {
            if (text.name == "ScoreText")
            {
                text.text = "" + sc.Score;
                continue;
            }
            if (text.name == "RecordText")
                text.text = "" + sc.Record;
        } 
    }

    void Initialize()
    {
        sc = FindObjectOfType<ScoreController>();
    }

    public void OnPauseBtn()
    {
        pausePanel.SetActive(true);
        lowerBtnPanel.SetActive(true);

        pauseBtn.SetActive(false);

        sc.StopGame();

        Debug.Log("Pause!");
    }
    public void OnExitBtn() {
        pausePanel.SetActive(false);
        lowerBtnPanel.SetActive(false);

        pauseBtn.SetActive(true);

        sc.Restart();

        Hide();
        UIHome.instance.ShowMenu();
    }
    public void OnContinueBtn() {
        pausePanel.SetActive(false);
        lowerBtnPanel.SetActive(false);

        pauseBtn.SetActive(true);

        sc.PlayGame();
    }
}
