using UnityEngine;
using System.Collections;

public class CheckGaz : MonoBehaviour
{
    private AudioSource GazSound;
    private TheScoreManger ScoreMange;

    void Start()
    {
        ScoreMange = FindObjectOfType<TheScoreManger>();
        GazSound = GameObject.Find("GazSound").GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            GazSound.Play();
            ScoreMange.GazScore += 20.0f;
            gameObject.SetActive(false);
        }
    }
}
