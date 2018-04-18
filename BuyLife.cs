using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyLife : MonoBehaviour {


    public GameObject ButtonBuyLife;
    public GameObject UnButtonBuyLife;
    public GameObject stay;
    private ShopButtons shop;
    public Text MyMoney;
    public GameObject NameOfProduct;


    void Start () {
        shop = GameObject.FindObjectOfType<ShopButtons>();
        if (PlayerPrefs.GetInt("boughtLife") == 1)
        {
            stay.SetActive(true);
        }
    }

    public void ButtonBuyPlanePressed()
    {
        ButtonBuyLife.SetActive(false);
        UnButtonBuyLife.SetActive(true);
        shop.SaveThemoney = float.Parse(MyMoney.text);
        shop.buyingLife = NameOfProduct.name;
    }
    public void ButtonBuyPlaneUnPressed()
    {
        ButtonBuyLife.SetActive(true);
        UnButtonBuyLife.SetActive(false);
    }
}
