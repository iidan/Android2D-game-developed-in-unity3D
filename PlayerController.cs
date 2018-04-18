using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public bool touchx = false;
    public GameObject shild;
    public GameObject shildOver;
    public GameObject bullonTurnOn;

    public Animator shildAnim1;
    public Animator anim;
    public Animator animWhile;
    public Animator SmokeAnim;
    public Animator SmokeStart;

    public AudioSource deathSound;
    public AudioSource StartEngin;
    public AudioSource bloonSound;
    public AudioSource HelicopterSound;


    public bool BubbleOnBool = false;
    private double time = 1f;
    //private TheGameIsOver gameover;
    private float counterLife;
    public bool ThePlayerUsedIsLife;
    public Collider2D player;
    private float saveSpeed = 0;
    public int myNumberForGameOver;
    public bool IsIndise ;
    private ThePlayerLoss pLoss;
    private bool MusicPlaneOn = true;

    void Start()
    {
        pLoss = FindObjectOfType<ThePlayerLoss>();
        //HelicopterSound.Play();
        //gameover = FindObjectOfType<TheGameIsOver>();
        counterLife = 2f;
        PlayerPrefs.SetFloat("SaveDistance", (int)600);
        IsIndise = false;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.name != "cilling")
        {
            animWhile.SetBool("touchTheGround", true);
        }
        if(other.gameObject.name == "cilling" || other.gameObject.name == "downSign")
        {
            saveSpeed = 0;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        animWhile.SetBool("touchTheGround", false);
    }
    void FixedUpdate()
    {
        if (MusicPlaneOn && SmokeStart.GetCurrentAnimatorStateInfo(0).IsName("SmokeEnded"))
        {
            HelicopterSound.Play();
            MusicPlaneOn = false;
        }
        if (Input.touchCount >= 1)
        {
            touchx = true;
        }
        if (touchx && SmokeStart.GetCurrentAnimatorStateInfo(0).IsName("SmokeEnded"))
        {            
            if (!BubbleOnBool)
            {
                transform.position -= new Vector3(0.0f, 4.5f * Time.deltaTime, 0.0f);
                HelicopterSound.volume = 0.33f;
               // anim.SetBool("TouchStart", false);
                //anim.SetBool("stopTocuh", true);

                //foreach (Touch touch in Input.touches)
                if (Input.touchCount >= 1)
                {
                    saveSpeed = saveSpeed + 0.12f; 
                    transform.position += new Vector3(0.0f, (8.8f + saveSpeed)* Time.deltaTime, 0.0f);
                    HelicopterSound.volume = 0.6f;
                    SmokeAnim.SetBool("ifTouchTheScreen", true);
                    //Vector3 Lerp(Vector3 start, Vector3 finish, float percentage)
                    // anim.SetBool("TouchStart", true);
                    //anim.SetBool("stopTocuh", false);
                }
                else
                {
                    SmokeAnim.SetBool("ifTouchTheScreen", false);
                    saveSpeed = 0;

                }
            }
            if (transform.position.x < -1.6f || transform.position.x > -1.6f)
            {
                transform.position = new Vector3(-1.6f, transform.position.y, transform.position.z);
            }
        }

        if (BubbleOnBool)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                bloonSound.Play();
                BubbleOnBool = false;
                bullonTurnOn.SetActive(false);
                time = 1f;
            }
        }

        if (ThePlayerUsedIsLife)
        {
            pLoss.BonusActive = true;
            counterLife -= Time.deltaTime;
            anim.SetBool("lifeStart", true);

            if (counterLife <= 0)
            {
                counterLife = 2f;
                ThePlayerUsedIsLife = false;
                anim.SetBool("lifeStart", false);
                pLoss.BonusActive = false;
            }
        }
    }
}
