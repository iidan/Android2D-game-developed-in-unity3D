using UnityEngine;
using System.Collections;

public class SpeedBonusScale : MonoBehaviour {

    public GameObject[] ScaleSpeed;
    public PowerUpBonus PUB;
    int temp;
    int counter;

    void Start()
    {
        PUB = FindObjectOfType<PowerUpBonus>();
        temp = 0;
        counter = 0;
    }

    public int SpeedUpCounter(int Num)
    {
        if(counter == 5)
        {
            counter = 0;
        }
        if (counter < 5)
        {
            ScaleSpeed[counter].SetActive(true);


            if (temp < counter)
            {
                ScaleSpeed[temp].SetActive(false);
            }

            temp = counter;
            counter++;

            return counter;
        }
        else
        {
            counter = 0;
            return counter = 0;
        }
    }
    void Update()
    {
        if(counter >= 4)
        {
            ScaleSpeed[4].SetActive(false);
        }
    }
}
