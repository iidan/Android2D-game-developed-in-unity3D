using UnityEngine;
using System.Collections;

public class ThePowerBonusManger : MonoBehaviour {

    private bool dublePoints;
    private bool ManyCoins;
    private bool SpeedUp;

    private bool PowerUpActive;
    private float PowerUpLengthCounter;

    //private TheScoreManger theScoreManger;
    private trackMove theTrackMoves;
    private PlayerController player;
    public wallsMove WallMoving;
    //private wallls WallTime;

    public float normalscoreCounter;
    private float speedPlayer;
    public float speedWall;
    private float SaveCount;
    private float wallTimerOn;

    private float sprikeRate;
    public bool flag = false;

    public bool SpeedBonus = false;
    public bool DoublePoints = false;
    public bool ExtraCoins = false;
    private float timerShowAnim = 2.5f;
    public GameObject SpeedBonusGO;
    public GameObject DoublePointsGO;
    public GameObject ExtraCoinsGO;

    private CoinsMaker coinmaker;
    private ThePlayerLoss playerLoss;

    // Use this for initialization
    void Start()
    {
        theTrackMoves = FindObjectOfType<trackMove>();
        player = FindObjectOfType<PlayerController>();
        //WallMoving = FindObjectOfType<wallsMove>();
        //WallTime = FindObjectOfType<wallls>();
        playerLoss = FindObjectOfType<ThePlayerLoss>();
        coinmaker = FindObjectOfType<CoinsMaker>();
    }

    void Update()
    {
        if (PowerUpActive)
        {
            PowerUpLengthCounter -= Time.deltaTime;

            if (dublePoints)
            {
                DoublePointsGO.SetActive(true);
                DoublePoints = true;
                theTrackMoves.score += 0.2f;
            }

            if (ManyCoins)
            {
                ExtraCoinsGO.SetActive(true);
                ExtraCoins = true;
                coinmaker.BonusCoins = true;
            }

            if (SpeedUp)
            {
                SpeedBonusGO.SetActive(true);
                SpeedBonus = true;

                theTrackMoves.speed = speedPlayer * 4.3f;
                theTrackMoves.wallSpeedMove = 75 * (speedPlayer * 4.3f);
                player.shild.SetActive(true);
                playerLoss.BonusActive = true;

                flag = true;
            }
            if(timerShowAnim > 0)
            {
                timerShowAnim -= Time.deltaTime;
            }
            if (timerShowAnim <= 0)
            {
                SpeedBonusGO.SetActive(false);
                //DoublePointsGO.SetActive(false);
                //ExtraCoinsGO.SetActive(false);

                SpeedBonus = false;
                DoublePoints = false;
                ExtraCoins = false;

            }

            if (PowerUpLengthCounter <= 2.5 && SpeedUp)
            {
                theTrackMoves.speed = theTrackMoves.GetSpeedNow();
                //theTrackMoves.wallSpeedMove = 75 * speedPlayer;
                //WallTime.timer = wallTimerOn;

                if (flag == true)
                {
                    player.shildOver.SetActive(true);
                    player.shild.SetActive(false);
                    player.shildAnim1.SetBool("timesUp", true);
                }
            }

            if (PowerUpLengthCounter <= 0)
            {
                PowerUpActive = false;
                timerShowAnim = 2.5f;

                if (flag == true)
                {
                    player.shild.SetActive(false);
                    player.shildOver.SetActive(false);
                }
                playerLoss.BonusActive = false;
            }
        }
    }

    public void ActivatePowerup(bool points, bool coins, bool speed, float time)
    {
        dublePoints = points;
        ManyCoins = coins;
        SpeedUp = speed;
        PowerUpLengthCounter = time;
        normalscoreCounter = theTrackMoves.score;

        speedPlayer = theTrackMoves.speed;
        if(speed && theTrackMoves.touchx)
        {
            speedWall = theTrackMoves.wallSpeedMove;
            //wallTimerOn = WallTime.timer;

        }
        PowerUpActive = true;

    }
}
