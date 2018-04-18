using UnityEngine;
using System.Collections;

public class topLamps : MonoBehaviour {

    public int counter;
    private AudioSource lampSound;
    public GameObject lamp;
    //private bool bump = true;

    void Start()
    {
        counter = PlayerPrefs.GetInt("CountTop");
        lampSound = GameObject.Find("LampTouch").GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            counter++;
            PlayerPrefs.SetInt("CountTop", counter);
            //gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 0.01f);

            if (lampSound.isPlaying)
            {
                lampSound.Stop();
                lampSound.Play();
            }
            else
            {
                lampSound.Play();
            }
            //bump = false;
        }
    }

    void Update()
    {
        if (lamp.transform.position.x <= -8.45f)
        {
            gameObject.transform.position = new Vector3(transform.position.x , transform.position.y , -1f);
        }
        counter = PlayerPrefs.GetInt("CountTop");
    }
}
