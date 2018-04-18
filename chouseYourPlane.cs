using UnityEngine;
using System.Collections;

public class chouseYourPlane : MonoBehaviour {

    public GameObject firstPlane;
    public GameObject AirPlane1;
    public GameObject AirPlane2;
    public GameObject AirPlane3;
    public GameObject AirPlane4;

    void Start()
    {
        AirPlane1.SetActive(true);

        if (PlayerPrefs.GetInt("chousen") == 2)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(true);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("chousen") == 3)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(true);
            AirPlane4.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("chousen") == 4)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(true);
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("chousen") == 2)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(true);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("chousen") == 3)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(true);
            AirPlane4.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("chousen") == 4)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(true);
        }
    }

    // Use this for initialization
    public void Theplayer(string MyString)
    {
        if(MyString == "plane1")
        {
            AirPlane1.SetActive(true);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(false);
            PlayerPrefs.SetInt("chouseYourPlane1", 1);
            PlayerPrefs.SetInt("chousen", 1);
        }
        if (MyString == "plane2" && PlayerPrefs.GetInt("boughtPlane1xx") == 1)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(true);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(false);
            PlayerPrefs.SetInt("chouseYourPlane2", 1);
            PlayerPrefs.SetInt("chousen", 2);
        }
        if (MyString == "plane3" && PlayerPrefs.GetInt("boughtPlane2xx") == 1)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(true);
            AirPlane4.SetActive(false);

            PlayerPrefs.SetInt("chouseYourPlane3", 1);
            PlayerPrefs.SetInt("chousen", 3);
            
        }
        if (MyString == "plane4" && PlayerPrefs.GetInt("boughtPlane3xx") == 1)
        {
            AirPlane1.SetActive(false);
            AirPlane2.SetActive(false);
            AirPlane3.SetActive(false);
            AirPlane4.SetActive(true);
            PlayerPrefs.SetInt("chouseYourPlane4", 1);
            PlayerPrefs.SetInt("chousen", 4);  
        }
    }
}
