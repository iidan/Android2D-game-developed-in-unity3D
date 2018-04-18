using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TheScoreManger : MonoBehaviour {

    public Text scoreText;
    public Text Coins;
    public Text ScoreNow;
    public Text HiScoreText;
    public Text Gaz;

    public float scoreCounter = 0;
    public float HiscoreCounter;

    public float GazScore;
    public float CoinsScore, CoinsScore2;
    public int OldCoins = 0;
    private trackMove track;
    public GameObject GameOver;
    //private ShopButtons shopButton;
    private bool OneTime = true;
    //private HSController hsCont;
    //////////////////////////
    private float SaveTempGaz;
    //////////////////////////
    private bool check;

    // Use this for initialization
    void Start()
    {

        //hsCont = FindObjectOfType<HSController>();
        HiscoreCounter = PlayerPrefs.GetFloat("highScore2");
        //shopButton = FindObjectOfType<ShopButtons>();
        PlayerPrefs.GetInt("CoinsScore3");
        CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
        CoinsScore2 = PlayerPrefs.GetInt("CoinsScorePik");
        track = FindObjectOfType<trackMove>();
        SaveTempGaz = PlayerPrefs.GetInt("SaveGaz");
        if (SaveTempGaz > 100)
        {
            GazScore = SaveTempGaz;
        }
    }

    // Update is called once per frame
    void Update()
    {

        scoreCounter = track.score;
        
        scoreText.text = "" + (int)scoreCounter + "m";
        ScoreNow.text = "" + (int)scoreCounter + "m";

        check = GameOver.activeSelf;
        if (check && OneTime == true)
        {
            OneTime = false;
            //hsCont.updateOnlineHighscoreData();
            if (PlayerPrefs.GetInt("MyScore") < (int)scoreCounter)
            {
                PlayerPrefs.SetInt("MyScore", (int)scoreCounter);
            }
        }

        if (scoreCounter > HiscoreCounter)
        {
            HiscoreCounter = scoreCounter;
            PlayerPrefs.SetFloat("highScore2", (int)HiscoreCounter);
        }
        HiScoreText.color = Color.red;
        HiScoreText.text = "" + (int)HiscoreCounter + "m";

        PlayerPrefs.SetInt("CoinsScore3", (int)CoinsScore);
        PlayerPrefs.SetInt("CoinsScorePik", (int)CoinsScore2);
        Coins.text = "" + CoinsScore;

        /////////////////GazScore/////////////////
        if (GazScore >= 100.9f && SaveTempGaz <= 100.9)
        {
            GazScore = 100.9f;
        }

        Gaz.text = (int)GazScore + "%";
        if(GazScore > 100)
        {
            PlayerPrefs.SetInt("SaveGaz", (int)GazScore);
        }
        if (Time.timeScale != 0)
        {
            GazScore = GazScore - 0.025f;
        }

        if (GazScore <= 0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
        //////////////////////////////////////////
    }

}
