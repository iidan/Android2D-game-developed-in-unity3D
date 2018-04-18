using UnityEngine;
using System.Collections;

public class AirPlanes : MonoBehaviour {

    public ObjectsPooler [] AirPlanePool;
    public GameObject AnimAirPlane;
    private int tempNumber ,temp;
    //private bool timerOn = false;
    private float timer2;
    private trackMove theTrack;
    public AudioSource PlaneSound;
    public Animator SignPlane;

    void Start()
    {
        theTrack = FindObjectOfType<trackMove>();
        timer2 = 4.2f;
        timer2 = Random.Range(6.5f, 12.5f);
        if (theTrack.score > 850)
        {
            timer2 = Random.Range(4.5f, 6.5f);
        }
        if (theTrack.score > 1500)
        {
            timer2 = Random.Range(3.2f, 6.5f);
        }
        InvokeRepeating("CallAirPlane", timer2, timer2);
    }
    public void SpwanAirPlane(Vector3 startPostition)
    {
        tempNumber = Random.Range(0, AirPlanePool.Length);
        GameObject Plane = AirPlanePool[tempNumber].GetPooledObjects();
        float SaveYlocation;
        int save = Random.Range(1, 10);
        if (save == 1 || save == 2)
        {
            SaveYlocation = 3.398f;
        }else
        {
            SaveYlocation = Random.Range(-0.3f, 1.86f);
        }
        Plane.transform.position = new Vector3(startPostition.x, SaveYlocation, -0.005f);
        AnimAirPlane.transform.position = new Vector3(AnimAirPlane.transform.position.x, SaveYlocation, 0.0f);
        AnimAirPlane.SetActive(true);
        Plane.SetActive(true);
        ///timerOn = true;
        InvokeRepeating("CallAnimAirPlaneSign", 1f, 1f);
        PlaneSound.Play();
    }
    void CallAirPlane()
    {
        if (theTrack.score > 320)
        {
            temp = Random.Range(0, 2);
            SpwanAirPlane(new Vector3(AirPlanePool[temp].transform.position.x + 3f, AirPlanePool[temp].transform.position.y, AirPlanePool[temp].transform.position.z));

        }
    }
    void CallAnimAirPlaneSign()
    {
        if (SignPlane.GetCurrentAnimatorStateInfo(0).IsName("end"))
        {
            //timerOn = false;
            AnimAirPlane.SetActive(false);
        }

    }
}
