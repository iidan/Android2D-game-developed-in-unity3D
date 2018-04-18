using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseManger : MonoBehaviour {

    public GameObject PauseUI;
    public GameObject pause;
    public GameObject scoreBoard;

    private ThePlayerLoss playerLoss;
    public GameObject gAME1;
    public GameObject gAME2;
    public GameObject question_Mark;
    public Animator SmokeStart;
    public AudioSource backgroundMusic;
    public AudioSource planesound;

    private float SaveSound;
    private bool check;
    void Start()
    {
        PauseUI.SetActive(false);
        pause.SetActive(false);
        SaveSound = backgroundMusic.volume;
        playerLoss = FindObjectOfType<ThePlayerLoss>();
    }

    void Update()
    {
        check = PauseUI.activeSelf;

        if (!check && SmokeStart.GetCurrentAnimatorStateInfo(0).IsName("SmokeEnded"))
        {
            pause.SetActive(true);
        }
        if (playerLoss.Gameover.activeSelf || scoreBoard.activeSelf)
        {
            pause.SetActive(false);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PauseUI.SetActive(true);
        planesound.Stop();
        gAME2.SetActive(false);
        backgroundMusic.volume = 0.1f;
    }

    public void Resume()
    {
        backgroundMusic.volume = SaveSound;
        Time.timeScale = 1;
        PauseUI.SetActive(false);
        pause.SetActive(true);
        //gAME1.transform.position = new Vector3(0.0f, SaveLocation, 0.0f);
        gAME2.SetActive(true);
        planesound.Play();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
        //Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    public void QuestionMarkOn()
    {
        question_Mark.SetActive(true);
    }
    public void QuestionMarkOff()
    {
        question_Mark.SetActive(false);
    }

}
