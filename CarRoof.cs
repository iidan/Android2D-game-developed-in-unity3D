using UnityEngine;
using System.Collections;

public class CarRoof : MonoBehaviour
{
    public int counter;
    private bool bump  = true; 
    void Start()
    {
        counter = PlayerPrefs.GetInt("CountCar1");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && bump)
        {
            counter = PlayerPrefs.GetInt("CountCar1");
            counter++;
            PlayerPrefs.SetInt("CountCar1", counter);
            bump = false;
        }
    }
}
