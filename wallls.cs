using UnityEngine;
using System.Collections;

public class wallls : MonoBehaviour {

    public ObjectsPooler[] theObjectPools;
    public float maxPos = 3.03f;
    public float timer,timer2;

    private trackMove theTrack;
    float scoreChange;
    float Save;
    public bool TimeIsCome;
    public float timeCoin;
    int temp ,countWalls = 5;
    float Rand ;

    Vector3 startPostition;
    CoinsMaker coin;
    SignPool sign;
    EnemyMoves Enemy;
    //AirPlanes Plane;
    GameObject wall;


    void Start()
    {
        theTrack = FindObjectOfType<trackMove>();
        coin = FindObjectOfType<CoinsMaker>();
        sign = FindObjectOfType<SignPool>();
        Enemy = FindObjectOfType<EnemyMoves>();
        //Plane = FindObjectOfType<AirPlanes>();
        timer = 4.2f;
        timeCoin = 5f;


        /// walls
        Rand = Random.Range(2.45f, 3f);
        timer = Rand;

        if (scoreChange > 300)
        {
            timer = Rand / 1.2f;
        }
        if (scoreChange > 550)
        {
            timer = Rand / 1.4f;
        }
        if (scoreChange > 800)
        {
            timer = Rand / 1.5f;
        }
        if (scoreChange > 1040)
        {
            timer = Rand / 1.6f;
        }
        if (scoreChange > 1220)
        {
            timer = Rand / 1.7f;
        }
        /// 
        InvokeRepeating("CallWalls", timer, timer);
        timer2 = Random.Range(8f, 15f);
        InvokeRepeating("CallBullon", timer2, timer2);
    }


    void CallWalls()
    {
        scoreChange = theTrack.score;
        if (theTrack.touchx)
        {
            if (!coin.coinOn)
            {
                temp = Random.Range(0, 7);

                if (temp == 0) { Save = -1.647f; }
                else if (temp == 1) { Save = -2.047f; }
                else if (temp == 2) { Save = 0.455f; }
                else if (temp == 3 || temp == 4) { Save = 3.226f; }
                else if (temp == 5) { Save = 0.455f; }
                else if (temp == 6) { Save = -2.209f; }

                if(temp != 3 || temp != 4)
                {
                    countWalls--;
                }else
                {
                    countWalls = 5;
                }
                if (countWalls <= 0)
                {
                    countWalls = 5;
                    temp = 4;
                    Save = 3.226f;
                }
                wall = theObjectPools[temp].GetPooledObjects();

                wall.transform.position = new Vector3(theObjectPools[temp].transform.position.x, Save, -0.005f);
                wall.SetActive(true);
                if (Random.Range(0f, 150f) < 15)
                {
                    CallBullon();
                }
                if (Random.Range(0f, 100f) < 23)
                {
                    CallSigns();
                    //timerSign = 0.3f;
                }
            }
        }
    }
    void CallSigns()
    {
        sign.SpwanSign(new Vector3(theObjectPools[temp].transform.position.x + 5.5f, transform.position.y, transform.position.z));
    }
    void CallBullon()
    {
        if (scoreChange >= 150)
        {
            Enemy.SpwanEnemy(new Vector3(16f, Random.Range(-2.56f,3.35f), -0.006f));
        }
    }
}
