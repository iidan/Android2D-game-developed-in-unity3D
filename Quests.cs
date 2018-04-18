using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Assets.scripts;

public class Quests : MonoBehaviour
{
    private TheScoreManger MangerScore;
    //private int Counter;
    private SignPool signPool;
    //private CarRoof carroof;
    //private topLamps topLamps;
    private GroundCounter ground;
    private Cilling cilling;
    private ThePlayerLoss playerLoss;
    //private WallMoveLeftAndRight Bullon;
    public AudioSource AddMoney;

    public GameObject[] CoinPic;
    public GameObject[] DisPic;
    public GameObject[] SignPic;
    public GameObject[] SignArrowPic;
    public GameObject[] CarRoofPic;
    public GameObject[] topLampPic;
    public GameObject[] GroundPic;
    public GameObject[] CillingPic;
    public GameObject[] InAirPic;
    public GameObject[] BullonPic;
    public GameObject[] Plane;

    ////////////////////////////////

    public Text[] text;
    public GameObject[] game;
    private int[] Num = { 1000, 500, 500, 180, 100, 500, 1800, 1500, 5000, 100 };
    private bool[] Bool = { false, false, false, false, false, false, false, false, false, false};

    private float SaveDistance;
    private int countLevel = 0 ,saveCoins;
    private int bulloonCounter;

    void Start()
    {

        MangerScore = FindObjectOfType<TheScoreManger>();
        signPool = FindObjectOfType<SignPool>();
        //carroof = FindObjectOfType<CarRoof>();
        //topLamps = FindObjectOfType<topLamps>();
        cilling = FindObjectOfType<Cilling>();
        ground = FindObjectOfType<GroundCounter>();
        playerLoss = FindObjectOfType<ThePlayerLoss>();
        //Bullon = FindObjectOfType<WallMoveLeftAndRight>();
        SaveDistance = PlayerPrefs.GetFloat("SaveDistance1");
        bulloonCounter = PlayerPrefs.GetInt("bullon");
    }
    void Update()
    {
        //MangerScore.CallMyMoney();
        if (countLevel == 0)
        {
            saveCoins = PlayerPrefs.GetInt("CoinsScorePik");
            CountQuests(CoinPic, PlayerPrefs.GetInt("CoinsScorePik").ToString(), text[0], Num[0], saveCoins, game[0], Bool[0], 1000 , 1311111);
            CountQuests2(DisPic, ((int)MangerScore.scoreCounter).ToString(), text[1], Num[1], MangerScore.scoreCounter, game[1], Bool[1], 500 ,SaveDistance,1322222);
            CountQuests(SignPic, signPool.CountSign.ToString(), text[2], Num[2], signPool.CountSign, game[2], Bool[2], 100,1333333);
            CountQuests(BullonPic, bulloonCounter.ToString(), text[9], Num[9], bulloonCounter, game[9], Bool[9], 100,1344444);
            if (Bool[0] && Bool[1] && Bool[2])
            {
                countLevel = 1;
            }
        }
        
        if (countLevel == 0)
        {
            CountQuests(SignArrowPic, signPool.CountArrowSign.ToString(), text[3], Num[3], signPool.CountArrowSign, game[3], Bool[3], 50 ,1355555);
            if (FindObjectOfType<CarRoof>())
            {
                CountQuests(CarRoofPic, FindObjectOfType<CarRoof>().counter.ToString(), text[4], Num[4], FindObjectOfType<CarRoof>().counter, game[4], Bool[4], 100 ,1366666);
            }
            if (FindObjectOfType<topLamps>())
            {
                CountQuests(topLampPic, FindObjectOfType<topLamps>().counter.ToString(), text[5], Num[5], FindObjectOfType<topLamps>().counter, game[5], Bool[5], 500 ,1377777);
            }
            if (Bool[3] && Bool[4] && Bool[5])
            {
                countLevel = 2; 
            }
        }

        if (countLevel == 0)
        {
            CountQuests(GroundPic, ground.counter.ToString(), text[6], Num[6], ground.counter, game[6], Bool[6], 600 ,1388888);
            CountQuests(CillingPic, cilling.counter.ToString(), text[7], Num[7], cilling.counter, game[7], Bool[7], 650 ,1399999);
            CountQuests(InAirPic, playerLoss.counter.ToString(), text[8], Num[8], playerLoss.counter, game[8], Bool[8], 1000 ,13111111);
            if (Bool[6] && Bool[7] && Bool[8])
            {
                countLevel = 3;
            }
        }

        if (PlayerPrefs.GetInt("boughtPlane1xx") == 1 || PlayerPrefs.GetInt("boughtPlane2xx") == 1 || PlayerPrefs.GetInt("boughtPlane3xx") == 1)
        {
            Plane[0].SetActive(true);
            Plane[1].SetActive(true);
            Plane[2].SetActive(true);
            game[10].SetActive(true);
            text[10].text = "1 / 1";
        }

    }
    private void CountQuests(GameObject[] tempArr,string ValueCounter, Text text, int Num,float Count, GameObject MissionEnd, bool BoolCheck,int AddTONum , int key)
    {
        text.text = ValueCounter + " / " + Num.ToString();

        if (Count >= Num)
        {
            if (Count >= Num)
            {
                tempArr[0].SetActive(true);
                AddTONum = Num;

                // Check if to turn on 1 STAR.
                string SaveKey1 = (key + 1).ToString();

                if (PlayerPrefs.GetInt(SaveKey1) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey1, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 100);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }
            }
            if (Count >= Num * 2)
            {
                tempArr[1].SetActive(true);
                AddTONum = Num * 2;

                // Check if to turn on 2 STAR.
                string SaveKey2 = (key + 2).ToString();

                if (PlayerPrefs.GetInt(SaveKey2) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey2, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 300);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }
            }
            if (Count >= Num * 3)
            {
                tempArr[2].SetActive(true);
                MissionEnd.SetActive(true);
                BoolCheck = true;
                AddTONum = Num * 3;

                // Check if to turn on 3 STAR.
                string SaveKey3 = (key + 3).ToString();

                if (PlayerPrefs.GetInt(SaveKey3) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey3, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 500);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }
            }
            if (!BoolCheck)
            {
                Num += AddTONum;
            }
            text.text = ValueCounter + " / " + Num.ToString();

        }
    }
    private void CountQuests2(GameObject[] tempArr, string ValueCounter, Text text, int Num, float Count, GameObject MissionEnd, bool BoolCheck, int AddTONum, float SaveInMemory , int key)
    {
        text.text = ValueCounter + " / " + Num.ToString();

        if (Count >= Num || SaveInMemory >= Count)
        {
            if (Count >= Num || SaveInMemory >= Num )
            {
                tempArr[0].SetActive(true);
                AddTONum = Num;

                // Check if to turn on 1 STAR.
                string SaveKey = (key + 1).ToString();

                if (PlayerPrefs.GetInt(SaveKey) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 100);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }
            }
            if (Count >= Num * 2 || SaveInMemory >= Num * 2)
            {
                tempArr[1].SetActive(true);
                PlayerPrefs.SetFloat("SaveDistance1", 1000);
                AddTONum = Num + 300;

                // Check if to turn on 2 STAR.
                string SaveKey = (key + 2).ToString();

                if (PlayerPrefs.GetInt(SaveKey) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 300);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }
            }
            if (Count >= Num + 300 || SaveInMemory >= Num + 300)
            {
                tempArr[2].SetActive(true);
                MissionEnd.SetActive(true);
                BoolCheck = true;
                PlayerPrefs.SetFloat("SaveDistance1", 1300);
                AddTONum = Num + 500;

                // Check if to turn on 3 STAR.
                string SaveKey = (key + 3).ToString();

                if (PlayerPrefs.GetInt(SaveKey) == 0)
                {
                    AddMoney.Play();
                    PlayerPrefs.SetInt(SaveKey, 1);
                    PlayerPrefs.SetInt("CoinsScore3", PlayerPrefs.GetInt("CoinsScore3") + 500);
                    MangerScore.CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
                }

            }
            if (!BoolCheck)
            {
                Num += AddTONum;
            }
            text.text = ValueCounter + " / " + Num.ToString();
        }
    }
}