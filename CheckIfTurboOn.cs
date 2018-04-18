using UnityEngine;
using System.Collections;

public class CheckIfTurboOn : MonoBehaviour {

    private ThePlayerLoss Playerloss;
    public GameObject T1, T2;
	void Start () {
        Playerloss = FindObjectOfType<ThePlayerLoss>();
        T1.SetActive(true);
        T2.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
        if (Playerloss.BonusActive)
        {
            T1.SetActive(false);
            T2.SetActive(false);
        }
        if (!Playerloss.BonusActive)
        {
            T1.SetActive(true);
            T2.SetActive(true);
        }
    }
}
