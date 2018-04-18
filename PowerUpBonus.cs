using UnityEngine;
using System.Collections;

public class PowerUpBonus : MonoBehaviour {

    public bool dublePoints;
    public bool ManyCoins;
    public bool SpeedUp;
    public int countSpeedUps;
    public bool SpeedButtonBonusOn;

    public float PowerUpLength;

    private ThePowerBonusManger thePowerManger;
    private AudioSource bonusSound;
    private SpeedBonusScale speedBonus;

    void Start()
    {
        thePowerManger = FindObjectOfType<ThePowerBonusManger>();
        bonusSound = GameObject.Find("BonusSound").GetComponent<AudioSource>();
        speedBonus = FindObjectOfType<SpeedBonusScale>();
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            
            bonusSound.Play();
            if (SpeedUp)
            {
                countSpeedUps = speedBonus.SpeedUpCounter(1);
            }
            if (countSpeedUps > 4)
            {
                thePowerManger.ActivatePowerup(dublePoints, ManyCoins, SpeedUp, PowerUpLength);
            }
            else
            {
                thePowerManger.ActivatePowerup(dublePoints, ManyCoins, false, PowerUpLength);
            }
            gameObject.SetActive(false);
        }
    }
}
