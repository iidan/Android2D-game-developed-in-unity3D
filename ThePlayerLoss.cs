using UnityEngine;
using System.Collections;

public class ThePlayerLoss : MonoBehaviour {

    public GameObject Gameover;
    public bool thePlayerLose = false;
    public bool BonusActive = false;
    private PlayerController player;
    private trackMove track;

    public float counter;
    public float SaveCounter;
    public int SaveCounter2;
    public Animator anim;
    public AudioSource bacgroundMusic;
    public AudioSource EndGame;

    void Start()
    {
        counter = PlayerPrefs.GetInt("AirTime1");
        SaveCounter = counter;
        anim.enabled = true;

        Gameover.SetActive(false);
        track = FindObjectOfType<trackMove>();
        player = FindObjectOfType<PlayerController>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!BonusActive)
        {
            if (other.name == "lamp2(Clone)" || other.name == "RoadSignTempWHIAT(Clone)" || other.name == "RoadSignTemp(Clone)"  || other.name == "lamp3(Clone)" || other.name == "lamp1(Clone)" || other.name == "Fpool4Move 1(Clone)"  || other.name == "Fpool4Red(Clone)" || other.name == "front" || other.name == "airplaneNew2(Clone)" || other.name == "airplaneNew4(Clone)" || other.name == "roadSign4(Clone)") 
            {
                anim.SetBool("isDied", true);
                
                player.deathSound.Play();
                Time.timeScale = 0;
                //if animation with name "Attack" finished

                thePlayerLose = true;
                track.setSpeed(false);
                bacgroundMusic.Stop();
            }
            BonusActive = false;
        }
    }

    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("End"))
        {
            Gameover.SetActive(true);
            EndGame.Play();
        }
        thePlayerLose = false;
        if (gameObject.name != "cilling" && gameObject.name != "ground2" && gameObject.name != "ground1" && Time.timeScale != 0)
        {
            CountAirTime();
        }

    }

    void CountAirTime()
    {
        SaveCounter += 0.1f;
        if ((int)SaveCounter > SaveCounter2)
        {
            SaveCounter2 = (int)SaveCounter;
            counter = SaveCounter2;
            PlayerPrefs.SetInt("AirTime1", (int)counter);
        }
    }
}
