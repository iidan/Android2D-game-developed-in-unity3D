using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ShopButtons : MonoBehaviour {

    //private float CoinsScore;
    //private Buying BuySomething;
    private GetInfromation getInfO;
    public GameObject WindowPurchase;
    public GameObject WindowAlreadyBought;
    public GameObject HelpWindow;
    private bool CheckIfBought;
    public int NumC = 1;
    public Text Money;

    public string AirPlaneName;
    public string buySomething;
    private TheScoreManger scoreManger;
    public float SaveThemoney;
    public float gazscore;
    private static BuyLife buylife;
    public string buyingLife;
    private static BoughtTurboStart buyTurbo;
    public string buyTurbostring;
    private BuyPlane buyplane;
    private bool CheckingIfThePLaneBought;
    public Animator SmokeStart;
    public AudioSource MoneySound;
    void Start()
    {
        //CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
        //BuySomething = GameObject.Find("slot").GetComponent<Buying>();
        //BuySomething = FindObjectOfType<Buying>();
        getInfO = FindObjectOfType<GetInfromation>();
        buylife = FindObjectOfType<BuyLife>();
        buyTurbo = FindObjectOfType<BoughtTurboStart>();
        buyplane = FindObjectOfType<BuyPlane>();
    }

    public void Menu()
    {
        // Go Back to the Main Menu.
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }
    public void PlayAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }
    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                int SaveCoins = PlayerPrefs.GetInt("CoinsScore3");
                PlayerPrefs.SetInt("CoinsScore3", SaveCoins + 50);
                getInfO.CallMyMoney();
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Failed:
                break;
        }
    }
    public void BuyTheProduct()
    {
        // Purches one or more item from the Shop List.
        if (NumC == 0)
        {
            NumC = 1;
        }
        float Save = NumC * SaveThemoney;
        float SAveCoinsScore = PlayerPrefs.GetInt("CoinsScore3");
        if (SAveCoinsScore > Save)
        {
            SAveCoinsScore = SAveCoinsScore - Save;
            PlayerPrefs.SetInt("CoinsScore3", (int)SAveCoinsScore);
            getInfO.UpdateCoinScore(SAveCoinsScore);
            CheckingIfThePLaneBought = true;
            MoneySound.Play();
        }
        WindowPurchase.SetActive(false);
        CheckIfBought = true;
    }
    public void PurchaseTheProducts()
    {
        if (AirPlaneName == "ButtonPlane1")
        {
            if(PlayerPrefs.GetInt("boughtPlane1xx") == 1)
            {
                buyplane.StayButton1.SetActive(true);
                WindowAlreadyBought.SetActive(true);
                WindowPurchase.SetActive(false);
            }
            else
            {
                BuyTheProduct();
                if (CheckingIfThePLaneBought)
                {
                    PlayerPrefs.SetInt("boughtPlane1xx", 1);
                    buyplane.StayButton1.SetActive(true);
                    CheckingIfThePLaneBought = false;
                }
            }
        }
        if (AirPlaneName == "ButtonPlane2")
        {
            if (PlayerPrefs.GetInt("boughtPlane2xx") == 1)
            {
                buyplane.StayButton2.SetActive(true);
                WindowAlreadyBought.SetActive(true);
                WindowPurchase.SetActive(false);
            }
            else
            {
                BuyTheProduct();
                if (CheckingIfThePLaneBought)
                {
                    PlayerPrefs.SetInt("boughtPlane2xx", 1);
                    buyplane.StayButton2.SetActive(true);
                    CheckingIfThePLaneBought = false;
                }
            }
        }
        if (AirPlaneName == "ButtonPlane3")
        {
            if (PlayerPrefs.GetInt("boughtPlane3xx") == 1)
            {
                buyplane.StayButton3.SetActive(true);
                WindowAlreadyBought.SetActive(true);
                WindowPurchase.SetActive(false);
            }
            else
            {
                BuyTheProduct();
                if (CheckingIfThePLaneBought)
                {
                    PlayerPrefs.SetInt("boughtPlane3xx", 1);
                    buyplane.StayButton3.SetActive(true);
                    CheckingIfThePLaneBought = false;
                }
            }
        }
        if (buySomething == "slotEnergy")
        {
            BuyTheProduct();
            gazscore = (100 + (10 * NumC ));
            PlayerPrefs.SetInt("SaveGaz", (int)gazscore);
        }

        if (buyTurbostring == "BuyTurbo")
        {
            if (PlayerPrefs.GetInt("boughtTurboStart") == 1)
            {
                WindowAlreadyBought.SetActive(true);
                WindowPurchase.SetActive(false);

            }
            else
            {
                BuyTheProduct();
                if (CheckingIfThePLaneBought)
                {
                    PlayerPrefs.SetInt("boughtTurboStart", 1);
                    buyTurbo.stay.SetActive(true);
                    CheckingIfThePLaneBought = false;
                }
            }
        }

        if (buySomething == "slotPotion")
        {

        }
        if (buyingLife == "BuyLife")
        {
            if(PlayerPrefs.GetInt("boughtLife") == 1)
            {
                WindowAlreadyBought.SetActive(true);
                WindowPurchase.SetActive(false);

                //PlayerPrefs.SetInt("boughtLife", 0);
            }
            else
            {
                BuyTheProduct();
                if (CheckingIfThePLaneBought)
                {
                    PlayerPrefs.SetInt("boughtLife", 1);
                    buylife.stay.SetActive(true);
                    CheckingIfThePLaneBought = false;
                }
            }
        }

    }

    public void CloseWindowQuestionMark()
    {
        HelpWindow.SetActive(false);
    }
    public void QuestionMark()
    {
        HelpWindow.SetActive(true);
    }

    public void CloseWindowPurchase()
    {
        WindowPurchase.SetActive(false);
    }
    public void TurnOnWindowPurchase()
    {
        WindowPurchase.SetActive(true);
        CheckIfBought = false;
    }
    public void CloseWindowAlreadyBought()
    {
        WindowAlreadyBought.SetActive(false);
    }

    public void SetCheckIfBought(bool CheckIfBoughtNew)
    {
        this.CheckIfBought = CheckIfBoughtNew;
    }
    public bool GetCheckIfBought()
    {
        return CheckIfBought;
    }
}
