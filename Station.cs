using UnityEngine;
using System.Collections;

public class Station : MonoBehaviour {

    public Animator anim;
    private bool Ended = false;
    // Use this for initialization
    void Start () {
        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("FirstMove"))
        {
            if (!Ended)
            {
                Time.timeScale = 1;
                Ended = true;
            }
        }

    }
}
