using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstTimeName : MonoBehaviour {

    public Text myName;
    private StartButton Sbutton;

    void Start()
    {
        Sbutton = FindObjectOfType<StartButton>();
    }

    public void MynameFunction()
    {
        PlayerPrefs.SetString("MynameInTheGame2", myName.text);

        string asd = System.Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(1, 8);
        PlayerPrefs.SetString("UserID", asd);

        Sbutton.ContainerBox.SetActive(true);
        Sbutton.NamePanel.SetActive(false);
    }
}
