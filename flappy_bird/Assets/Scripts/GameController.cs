using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject PipePrefabs;

    public GameObject bird;

    double TimeCreate;

    private int score;
    private bool isGameOver;
    private bool startGame = false;



    private UI m_ui;

    void Awake()
    {
        // Debug.Log(TimeCreate);
        m_ui = FindObjectOfType<UI>();
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        TimeCreate -= Time.deltaTime;
        if (TimeCreate <= 0 && this.startGame == true)
        {
            CreatePipe();
            TimeCreate = 2;
        }
    }
    public void CreatePipe()
    {
        Vector2 PipePos = new Vector2(11, Random.Range((float)-4.5, (float)-2.75));
        if (PipePrefabs)
        {
            Instantiate(PipePrefabs, PipePos, Quaternion.identity);

        }

    }
    public void IncreaseScore()
    {
        this.score++;
        m_ui.SetScoreText("" + this.score);
    }
    public int GetScore()
    {
        return this.score;
    }

    public bool GetIsGameOver()
    {
        return this.isGameOver;
    }

    public void SetIsGameOver(bool value)
    {
        this.isGameOver = value;
        m_ui.SetActiveGameOverPanel(isGameOver);


    }

    public void SetStartGame(bool value)
    {
        this.startGame = value;
    }

    public bool GetStartGame()
    {
        return this.startGame;
    }

    public void Replay()
    {
        this.isGameOver = false;
        SetIsGameOver(false);
        this.score = 0;
        m_ui.SetScoreText("" + this.score);
        this.startGame = false;
        m_ui.SetEnableStartMessage(true);

        Instantiate(bird, new Vector3(-1.71f, 0, 0), Quaternion.identity);

    }

    public void Play()
    {
        startGame = true;
        score = 0;
        isGameOver = false;
        m_ui.SetEnableStartMessage(false);
    }



}
