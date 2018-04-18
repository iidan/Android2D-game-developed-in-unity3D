using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

    public GameObject menu;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MenuButtonCllicked()
    {
        menu.SetActive(true);

    }
}
