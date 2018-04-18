using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyScore : MonoBehaviour {

    public Text myScore;

	// Use this for initialization
	void Start () {
        int save = PlayerPrefs.GetInt("MyScore");
        myScore.text = save.ToString();
    }
}
