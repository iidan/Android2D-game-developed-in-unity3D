using UnityEngine;
using System.Collections;

public class WallMoveLeftAndRight : MonoBehaviour {

    private float maxWidth = 3.398f;
    private float minWidth = -1.73f;
    private int saveNum;
    private trackMove track;
    private PlayerController player;

    public int counterBullon;

    // Use this for initialization
    void Start()
    {
        counterBullon = PlayerPrefs.GetInt("bullon");
        saveNum = Random.Range(1, 3);
        track = FindObjectOfType<trackMove>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        counterBullon = PlayerPrefs.GetInt("bullon");

        transform.position -= new Vector3((1.5f  + track.wallSpeedMove) * Time.smoothDeltaTime , 0.0f, -0.006f);

        if (saveNum == 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, -0.006f);
        }
        else if (saveNum == 2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, -0.006f);
        }
        if (transform.position.y >= maxWidth)
        {
            saveNum = 2;
        }
        else if (transform.position.y <= minWidth)
        {
            saveNum = 1;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            counterBullon++;
            PlayerPrefs.SetInt("bullon", counterBullon);
            player.BubbleOnBool = true;
            gameObject.SetActive(false);
            player.bullonTurnOn.SetActive(true);
        }
    }
}