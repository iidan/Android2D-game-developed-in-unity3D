using UnityEngine;
using System.Collections;

public class SpeedBonusButton : MonoBehaviour {

    private ThePowerBonusManger thePowerManger;

    // Use this for initialization
    void Start () {
        thePowerManger = FindObjectOfType<ThePowerBonusManger>();
    }

    public void ButtonSpeedClicked()
    {
        thePowerManger.ActivatePowerup(false, false, true, 0);
    }

}
