using UnityEngine;
using System.Collections;

public class Cilling : MonoBehaviour {
    public float counter;
    private float SaveCounter;
    private int SaveCounter2;
    void Start()
    {
        counter = PlayerPrefs.GetInt("Cilling1");
        SaveCounter = counter;
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            TopCilling();
        }
    }

    public void TopCilling()
    {
        SaveCounter += 0.1f;
        if ((int)SaveCounter > SaveCounter2)
        {
            SaveCounter2 = (int)SaveCounter;
            counter = SaveCounter2;
            PlayerPrefs.SetInt("Cilling1", (int)counter);
        }

    }
}
