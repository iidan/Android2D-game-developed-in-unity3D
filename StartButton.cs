using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    public GameObject panel;
    public GameObject LoadingScreen;
    private float time;
    public bool Actived;
    public GameObject NamePanel;
    public GameObject ContainerBox;
    public GameObject internetChecking;
    public GameObject bannerAd;
    public GameObject Setteings;
    void Start()
    {
        time = 0.1f;
        //Time.timeScale = 0;
        string Myname = PlayerPrefs.GetString("MynameInTheGame2").ToString();

        if (Myname == string.Empty)
        {
            if (Application.internetReachability != NetworkReachability.NotReachable)
            {
                NamePanel.SetActive(true);
                ContainerBox.SetActive(false);
            }else
            {
                internetChecking.SetActive(true);
            }

        }
        bannerAd.SetActive(true);

    }

    void Update()
    {
        if (Actived)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                SceneManager.LoadScene("TheGameF");
            }
        }
    }
    // Update is called once per frame
    public void StartTheGame()
    {
        Actived = true;
        LoadingScreen.SetActive(true);
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Missions()
    {
        SceneManager.LoadScene("missions");
    }
    public void facebook()
    {

    }
    public void BannerAds()
    {
        bannerAd.SetActive(false);
    }
    public void settings()
    {
        Setteings.SetActive(true);
    }
    public void settingsoff()
    {
        Setteings.SetActive(false);
    }
    public void share()
    {

    }
    public void internetCheckingoff() {
        internetChecking.SetActive(false);
    }
    public void BoardScore()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            SceneManager.LoadScene("ScoreBoard");

        }
        else
        {
            internetChecking.SetActive(true);
        }
    }
}
