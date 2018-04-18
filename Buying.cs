using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buying : MonoBehaviour {

    public GameObject[] objects;
    public Text MyMoney;
    private int CounteObjects = 0;
    private static int CounteObjectsB;
    private ShopButtons shop;
    public GameObject NameOfProduct;

    void Start()
    {
        shop = GameObject.FindObjectOfType<ShopButtons>();
    }
    // Call this function to increase every time by one plate.
    public void PlusButtonClicked()
    {
        shop.buySomething = NameOfProduct.name;
        CounteObjects++;
        shop.SaveThemoney = float.Parse(MyMoney.text);
        shop.NumC = CounteObjects;
        if (CounteObjects > 5)
        {
            CounteObjects = 5;
        }
        objects[CounteObjects].SetActive(true);
    }

    // Call this function to decrease every time by one plate.
    public void MinusButtonClicked()
    {
        if(CounteObjects > 0)
        {
            objects[CounteObjects].SetActive(false);
        }
        if (CounteObjects < 1)
        {
            CounteObjects = 1;
        }
        CounteObjects--;
        shop.NumC = CounteObjects;
    }

    public int GetCounteObjects()
    {
        return this.CounteObjects;
    }
    public void SetCounteObjects(int NewCounteObjects)
    {
        CounteObjects = NewCounteObjects;
    }
}
