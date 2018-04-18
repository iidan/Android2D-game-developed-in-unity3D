using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {

    public float speed;
    public float wallSpeedMove;
    Vector2 offset;
    public bool touchx = false , boolGet1 = true , boolGet2 = true, boolGet3 = true;
    public float score = 0;
    private float speedChange , SpeedExtra = 1f , myspeed;
    private bool StillAlive = true;
    private PlayerController player;
    private int AddtoScore = 0;
    public AudioSource HelicopterSound;

    void Start()
    {
        speedChange = speed;
        player = FindObjectOfType<PlayerController>();
    }
    void Update () {
        if (player.SmokeStart.GetCurrentAnimatorStateInfo(0).IsName("SmokeEnded"))
        {
            if (Input.touchCount >= 1)
            {
                touchx = true;
            }
            if (touchx && StillAlive)
            {
                if (Time.timeScale != 0)
                {
                    score += 0.1f;
                }

                myspeed = speed * Time.smoothDeltaTime;
                offset += new Vector2(myspeed, 0);
                GetComponent<Renderer>().material.mainTextureOffset = offset;
                wallSpeedMove =  14.5f * (speed);
            }
            if (score > (320 + AddtoScore))
            {
                SpeedExtra = SpeedExtra + 0.28f;
                AddtoScore += 200;
                speed = speedChange * SpeedExtra;
                //wallSpeedMove = WallspeedChange * SpeedExtra;
            }
           // wallSpeedMove = WallspeedChange * SpeedExtra;
        }

        
    }
    
    public float GetSpeedNow()
    {
        speed = speedChange * SpeedExtra;
        return speed;
    }
    public void setSpeed(bool speed)
    {
        StillAlive = speed;
    }
}
