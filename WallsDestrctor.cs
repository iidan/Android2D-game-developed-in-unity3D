using UnityEngine;
using System.Collections;

public class WallsDestrctor : MonoBehaviour {

    public GameObject poolDestructionPoint;
    //private signScript signS;
    private AirPlanes Plane;
    private topLamps TopLamps; 
    
    void Start()
    {
        poolDestructionPoint = GameObject.Find("wallsDestrctor");
        //signS = FindObjectOfType<signScript>();
        Plane = FindObjectOfType<AirPlanes>();
    }

    void Update()
    {
        if (transform.position.x < poolDestructionPoint.transform.position.x)
        {
            if (gameObject.name == "airplane(Clone)")
            {
                Plane.AnimAirPlane.SetActive(false);
            }
            gameObject.SetActive(false);
        }
    }
}
