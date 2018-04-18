using UnityEngine;
using System.Collections;

public class CarGeneration : MonoBehaviour
{

    public ObjectsPooler[] Carpool;
    private float time = 4f;
    private int tempNumber;
    void Start()
    {
        time = Random.Range(3, 5);
        InvokeRepeating("CallCar", time, time);
    }
    void CallCar()
    {
        tempNumber = Random.Range(0, Carpool.Length);
        GameObject car = Carpool[tempNumber].GetPooledObjects();
        car.transform.position = new Vector3(Carpool[tempNumber].transform.position.x, 0.0f, -0.004f);
        car.SetActive(true);
    }
}
