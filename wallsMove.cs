using UnityEngine;
using System.Collections;

public class wallsMove : MonoBehaviour {

    private trackMove theTrack;
    public float speedWallMove;

	void Start () {
        theTrack = FindObjectOfType<trackMove>();
        speedWallMove = theTrack.wallSpeedMove;
    }
	
	void Update ()
    {
        speedWallMove = theTrack.wallSpeedMove;
        transform.position -= new Vector3((speedWallMove) * Time.smoothDeltaTime, 0.0f, 0.0f);
    }
}
