using UnityEngine;
using System.Collections;

public class backGroundReplace : MonoBehaviour {

    public GameObject Track1;
    public GameObject[] tracks;
    private trackMove trackmove;
    private int ScoreCounter = 30;

    void Start()
    {
        trackmove = FindObjectOfType<trackMove>();
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1; i++)
        {
            if (trackmove.score > ScoreCounter)
            {
                tracks[i].SetActive(true);

                if (tracks[i].transform.position.x >= 0)
                {
                    tracks[i].transform.position -= new Vector3(Time.deltaTime * 2, 0.0f, 0.0f);
                }
                if (tracks[i].transform.position.x <= 0.01)
                {
                    Track1.SetActive(false);
                    ScoreCounter += 15;
                }
            }
        }
    }
}
