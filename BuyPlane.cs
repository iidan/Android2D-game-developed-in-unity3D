using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyPlane : MonoBehaviour {

    public GameObject ButtonAirPlane1;
    public GameObject UnButtonAirPlane1;
    public GameObject ButtonAirPlane2;
    public GameObject UnButtonAirPlane2;
    public GameObject ButtonAirPlane3;
    public GameObject UnButtonAirPlane3;
    public Text MyMoney1;
    public Text MyMoney2;
    public Text MyMoney3;
    private ShopButtons shop;
    public GameObject StayButton1;
    public GameObject StayButton2;
    public GameObject StayButton3;


    // Use this for initialization
    void Start() {
        shop = GameObject.FindObjectOfType<ShopButtons>();
        if (PlayerPrefs.GetInt("boughtPlane1xx") == 1)
        {
            StayButton1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("boughtPlane2xx") == 1)
        {
            StayButton2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("boughtPlane3xx") == 1)
        {
            StayButton3.SetActive(true);
        }
    }

    public void ButtonAirPlanePressed1()
    {
        shop.AirPlaneName = ButtonAirPlane1.name;
        ButtonAirPlane1.SetActive(false);
        UnButtonAirPlane1.SetActive(true);

        ButtonAirPlane2.SetActive(true);
        UnButtonAirPlane2.SetActive(false);
        ButtonAirPlane3.SetActive(true);
        UnButtonAirPlane3.SetActive(false);
        shop.SaveThemoney = float.Parse(MyMoney1.text);

    }

    public void ButtonAirPlanePressed2()
    {
        shop.AirPlaneName = ButtonAirPlane2.name;
        ButtonAirPlane2.SetActive(false);
        UnButtonAirPlane2.SetActive(true);

        ButtonAirPlane1.SetActive(true);
        UnButtonAirPlane1.SetActive(false);
        ButtonAirPlane3.SetActive(true);
        UnButtonAirPlane3.SetActive(false);
        shop.SaveThemoney = float.Parse(MyMoney2.text);

    }

    public void ButtonAirPlanePressed3()
    {
        shop.AirPlaneName = ButtonAirPlane3.name;
        ButtonAirPlane3.SetActive(false);
        UnButtonAirPlane3.SetActive(true);

        ButtonAirPlane1.SetActive(true);
        UnButtonAirPlane1.SetActive(false);
        ButtonAirPlane2.SetActive(true);
        UnButtonAirPlane2.SetActive(false);
        shop.SaveThemoney = float.Parse(MyMoney3.text);

    }
    public void ButtonAirPlaneUnPressed()
    {
        if (ButtonAirPlane1)
        {
            ButtonAirPlane1.SetActive(true);
            UnButtonAirPlane1.SetActive(false);
        }
        if (ButtonAirPlane2)
        {
            ButtonAirPlane2.SetActive(true);
            UnButtonAirPlane2.SetActive(false);
        }
        if (ButtonAirPlane3)
        {
            ButtonAirPlane3.SetActive(true);
            UnButtonAirPlane3.SetActive(false);
        }
    }
}
