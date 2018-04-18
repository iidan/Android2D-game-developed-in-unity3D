using UnityEngine;
using System.Collections;

public class moveCar : MonoBehaviour {

    private float speedcar;
    private trackMove track;

    void Start()
    {
        track = FindObjectOfType<trackMove>();
    }
    // Update is called once per frame
    void Update () {
        speedcar = track.wallSpeedMove;

        transform.position -= new Vector3((speedcar + 1.3f) * Time.smoothDeltaTime, 0.0f, 0.0f);
    }


}
