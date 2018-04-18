using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoughtTurboStart : MonoBehaviour {

    public GameObject ButtonBuyTurboStart;
    public GameObject UnButtonBuyTurboStart;
    public GameObject stay;
    private ShopButtons shop;
    public Text MyMoney;
    public GameObject NameOfProduct;


    void Start()
    {
        shop = FindObjectOfType<ShopButtons>();
        if (PlayerPrefs.GetInt("boughtTurboStart") == 1)
        {
            stay.SetActive(true);
        }
    }

    public void ButtonBuyPlanePressed()
    {
        ButtonBuyTurboStart.SetActive(false);
        UnButtonBuyTurboStart.SetActive(true);
        shop.SaveThemoney = float.Parse(MyMoney.text);
        shop.buyTurbostring = NameOfProduct.name;
    }
    public void ButtonBuyPlaneUnPressed()
    {
        ButtonBuyTurboStart.SetActive(true);
        UnButtonBuyTurboStart.SetActive(false);
    }
}
