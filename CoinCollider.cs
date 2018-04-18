using UnityEngine;
using System.Collections;

public class CoinCollider : MonoBehaviour {

    public int countCoins = 0;
    public bool ScoreCoins = false;

    private AudioSource coinSound;
    private TheScoreManger ScoreMange;
    void Start()
    {
        coinSound = GameObject.Find("CoinSound12").GetComponent<AudioSource>();
        ScoreMange = FindObjectOfType<TheScoreManger>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "playerH1_2" || other.gameObject.name == "Player")
        {
            ScoreCoins = true;
            gameObject.SetActive(false);            
            if (coinSound.isPlaying)
            {
                coinSound.Stop();
                coinSound.Play();
            }
            else
            {
                coinSound.Play();
            }
            ScoreMange.CoinsScore++;
            ScoreMange.CoinsScore2++;
        }

    }
    void Update()
    {
        ScoreCoins = false;
    }
}
