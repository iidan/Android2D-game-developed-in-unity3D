using UnityEngine;
using System.Collections;

public class SignMove : MonoBehaviour {

    private float speedSign;
    private trackMove track;
    void Start()
    {
        track = FindObjectOfType<trackMove>();
    }

    // Update is called once per frame
    void Update () {
        speedSign = track.wallSpeedMove;
        transform.position -= new Vector3(speedSign * Time.smoothDeltaTime, 0.0f, 0.0f);
    }
}
