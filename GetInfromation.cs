using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInfromation : MonoBehaviour {

    private TheScoreManger theScoreM;
    public Text coins;
    private float CoinsScore;
    // Use this for initialization

    void Start () {
        CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
    }
	
	// Update is called once per frame
	void Update () {
        coins.text = "" + CoinsScore;
    }

    public void UpdateCoinScore(float SAveCoinsScore)
    {
        this.CoinsScore = SAveCoinsScore;
    }

    public void CallMyMoney()
    {
        CoinsScore = PlayerPrefs.GetInt("CoinsScore3");
    }
}
