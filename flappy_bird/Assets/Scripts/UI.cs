using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    public GameObject gameOverPanel;

    public GameObject startMessage;
    public void SetScoreText(string txt)
    {
        if (scoreText)
        {
            this.scoreText.text = txt;
        }
    }

    public void SetActiveGameOverPanel(bool value)
    {
        if (this.gameOverPanel)
        {
            gameOverPanel.SetActive(value);
        }
    }

    public void SetEnableStartMessage(bool value)
    {
        if (this.startMessage)
        {
            startMessage.SetActive(value);
        }
    }


}
