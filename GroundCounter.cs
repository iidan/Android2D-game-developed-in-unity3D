using UnityEngine;
using System.Collections;

public class GroundCounter : MonoBehaviour {

    public float counter;
    private float SaveCounter;
    private int SaveCounter2;

    void Start()
    {
        counter = PlayerPrefs.GetInt("ground4");
        SaveCounter = counter;
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ground();
        }
    }


    public void Ground()
    {
        SaveCounter += 0.1f;
        if ((int)SaveCounter > SaveCounter2)
        {
            SaveCounter2 = (int)SaveCounter;
            counter = SaveCounter2;
            PlayerPrefs.SetInt("ground4", (int)counter);
        }
    }
}
