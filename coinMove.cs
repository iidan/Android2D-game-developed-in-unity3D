using UnityEngine;
using System.Collections;

public class coinMove : MonoBehaviour {

    private float speedCoin;
    private trackMove track;

    void Start () {
        track = FindObjectOfType<trackMove>();
    }

    // Update is called once per frame
    void Update () {
        speedCoin = track.wallSpeedMove;
        transform.position -= new Vector3((speedCoin) * Time.smoothDeltaTime, 0.0f, 0.0f);
    }
}
