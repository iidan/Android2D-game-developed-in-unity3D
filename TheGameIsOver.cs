using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class TheGameIsOver : MonoBehaviour {

    public GameObject Gameover;
    public GameObject [] playerLoss;
    private trackMove track;
    public GameObject lifeButtonOn;
    public GameObject lifeButtonOff;
    public Collider2D  [] player;
    private PlayerController playerCo;
    public GameObject ScoreBoard;
    public GameObject networkCheck;
    public AudioSource HelicopterSound;
    private PauseManger pause;
    void Start()
    {
        pause = FindObjectOfType<PauseManger>();
        track = FindObjectOfType<trackMove>();
        playerCo = FindObjectOfType<PlayerController>();
        Gameover.SetActive(true);
        playerLoss[playerCo.myNumberForGameOver].SetActive(false);
        HelicopterSound.Stop();
        if (PlayerPrefs.GetInt("boughtLife") == 1)
        {
            lifeButtonOn.SetActive(true);
            lifeButtonOff.SetActive(false);
        }
        else
        {
            lifeButtonOn.SetActive(false);
            lifeButtonOff.SetActive(true);
        }
    }
    public void networkCheckoff()
    {
        networkCheck.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        playerLoss[playerCo.myNumberForGameOver].SetActive(true);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("TheGameF");
        playerLoss[playerCo.myNumberForGameOver].SetActive(true);
        Time.timeScale = 0;
    }
    public void BoardScoreOn()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            ScoreBoard.SetActive(true);
            Gameover.SetActive(false);
            pause.pause.SetActive(false);
        }
        else
        {
            networkCheck.SetActive(true);
        }
    }
    public void BoardScoreOff()
    {
        ScoreBoard.SetActive(false);
        Gameover.SetActive(true);
    }
    public void lifeOn()
    {
        //player[playerCo.myNumberForGameOver].enabled = false;

        playerCo.ThePlayerUsedIsLife = true;
        PlayerPrefs.SetInt("boughtLife", 0);
        Time.timeScale = 1;
        track.setSpeed(true);
        playerLoss[playerCo.myNumberForGameOver].SetActive(true);

        lifeButtonOff.SetActive(true);
        lifeButtonOn.SetActive(false);
        Gameover.SetActive(false);
    }

}
