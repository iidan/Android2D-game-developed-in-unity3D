using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class scrollTouch : MonoBehaviour {
    public Scrollbar MyScrollbar;
    public List<Image> levels;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.touchCount == 0)
        {
            if(MyScrollbar.GetComponent<Scrollbar>().value < 0.054f)
            {
                MyScrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(MyScrollbar.GetComponent<Scrollbar>().value, 0, 1f);
            }
            else if (MyScrollbar.GetComponent<Scrollbar>().value >= 0.054f && MyScrollbar.GetComponent<Scrollbar>().value < 0.393f)
            {
                MyScrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(MyScrollbar.GetComponent<Scrollbar>().value, 0.3335f, 1f);
            }
            else if (MyScrollbar.GetComponent<Scrollbar>().value >= 0.633f && MyScrollbar.GetComponent<Scrollbar>().value < 0.701f)
            {
                MyScrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(MyScrollbar.GetComponent<Scrollbar>().value, 0.6669999f, 1f);
            }
            else if (MyScrollbar.GetComponent<Scrollbar>().value >= 0.701f && MyScrollbar.GetComponent<Scrollbar>().value < 1f)
            {
                MyScrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(MyScrollbar.GetComponent<Scrollbar>().value, 1f, 1f);
            }
        }
    }
}
