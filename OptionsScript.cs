using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour {

    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject fxOn;
    public GameObject fxOff;
    private int SondSave;
    private int MusicSave;

    void Start()
    {

        if (PlayerPrefs.GetInt("SoundGame") == 1)
        {
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SoundGame") == 2)
        {
            musicOff.SetActive(true);
            musicOn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("FxSound") == 1)
        {
            fxOn.SetActive(true);
            fxOff.SetActive(false);
        }
        if (PlayerPrefs.GetInt("FxSound") == 2)
        {
            fxOff.SetActive(true);
            fxOn.SetActive(false);
        }
    }

    public void musicoff()
    {
        musicOff.SetActive(false);
        musicOn.SetActive(true);
        PlayerPrefs.SetInt("SoundGame" , 1);
    }
    public void musicon()
    {
        musicOn.SetActive(false);
        musicOff.SetActive(true);
        PlayerPrefs.SetInt("SoundGame", 2);
    }
    public void fxon()
    {
        fxOn.SetActive(false);
        fxOff.SetActive(true);
        PlayerPrefs.SetInt("FxSound" , 2);
    }
    public void fxoff()
    {
        fxOff.SetActive(false);
        fxOn.SetActive(true);
        PlayerPrefs.SetInt("FxSound", 1);
    }
    public void Return()
    {
        SceneManager.LoadScene("menu");
    }
}
