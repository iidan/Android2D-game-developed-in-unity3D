using UnityEngine;
using System.Collections;

public class signScript : MonoBehaviour {

    public Animator AnimSign1;
    public Animator AnimSign2;
    public Animator AnimSign3;
    public Animator AnimSign4;
    private AudioSource Hit_Sign_Road;

    public int CounterSigns;
    private SignPool sign;

    void Start()
    {
        //AnimSign1 = GetComponent<Animator>();
        sign = FindObjectOfType<SignPool>();
        Hit_Sign_Road = GameObject.Find("hit_Sign_road").GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Hit_Sign_Road.Play();
            if (gameObject.tag == "SignYellow")
            {
                AnimSign1.SetBool("yes", true);
                sign.CounterArrowSigns();
            }
            if (gameObject.tag == "SignBlue")
            {
                AnimSign2.SetBool("ifHitBlue", true);
            }
            if (gameObject.tag == "SignGreen")
            {
                AnimSign3.SetBool("ifHitGreen", true);
            }
            if (gameObject.tag == "SignRed")
            {
                AnimSign4.SetBool("ifHitRed", true);
            }
            sign.CounterSigns();
        }
    }
}
