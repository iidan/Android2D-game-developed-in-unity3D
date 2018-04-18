using UnityEngine;
using System.Collections;

public class CameraMoves : MonoBehaviour {

    public PlayerController thePlayer;

    private Vector3 lastPlayerPostition;
    private float distanceToMove;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPostition = thePlayer.transform.position;
    }

    void LateUpdate()
    {
        distanceToMove = thePlayer.transform.position.y - lastPlayerPostition.y;
        transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);
        lastPlayerPostition = thePlayer.transform.position;
    }
}
