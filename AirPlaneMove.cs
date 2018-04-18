using UnityEngine;
using System.Collections;

public class AirPlaneMove : MonoBehaviour {

    private float speedcar;
    public float SpeedAdd;
    private trackMove track;

    void Start()
    {
        track = FindObjectOfType<trackMove>();
    }

    // Update is called once per frame
    void Update()
    {
        speedcar = track.wallSpeedMove;

        transform.position -= new Vector3((speedcar + SpeedAdd) * Time.smoothDeltaTime, 0.0f, 0.0f);
    }
}
