using UnityEngine;
using System.Collections;

public class TurboStart : MonoBehaviour {

    public GameObject ShildOn;
    public GameObject ShildOver;
    private trackMove track;
    private float SAveSpeedStart;
    private bool  TheSpeedStarted;
    private float timer = 7f;
    private PlayerController player;
    public Animator SmokeStart;
    private ThePlayerLoss Playerloss;
    private float SpeedNow;
    void Start ()
    {
        track = FindObjectOfType<trackMove>();
        SAveSpeedStart = track.speed;
        player = FindObjectOfType<PlayerController>();
        Playerloss = FindObjectOfType<ThePlayerLoss>();
        SpeedNow = track.speed;
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("boughtTurboStart") == 1)
        {
            TheSpeedStarted = true;
            if (SmokeStart.GetCurrentAnimatorStateInfo(0).IsName("SmokeEnded"))
            {
                if (TheSpeedStarted)
                {
                    track.speed = SpeedNow * 4.3f;
                    ShildOn.SetActive(true);
                    TheSpeedStarted = false;
                    Playerloss.BonusActive = true;
                }
                timer -= Time.deltaTime;
                if (timer <= 2.5f)
                {
                    ShildOver.SetActive(true);
                    ShildOn.SetActive(false);
                    player.shildAnim1.SetBool("timesUp", true);
                    track.speed = SAveSpeedStart;
                }
                if (timer <= 0)
                {
                    ShildOn.SetActive(false);
                    ShildOver.SetActive(false);
                    Playerloss.BonusActive = false;
                    PlayerPrefs.SetInt("boughtTurboStart", 0);
                }
            }
        }

    }
}
