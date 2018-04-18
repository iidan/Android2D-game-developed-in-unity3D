using UnityEngine;
using System.Collections;

public class NewBackGroundChangeForQuad : MonoBehaviour {

    public GameObject Leve1BackGround;
    public GameObject Leve2BackGround;
    public GameObject Leve3BackGround;
    public GameObject Leve4BackGround;
    public GameObject mainMapp;

    public trackMove MainTrack;
    private float saveLocationLevel = 0.0f;
    private int AddToScore;
    private bool [] checkBack = { true , true , true , true , true };

    void Start()
    {
        AddToScore = 0;
        MainTrack = FindObjectOfType<trackMove>();
    }
    // Update is called once per frame
    void Update()
    {

        if (MainTrack.score > 300 + AddToScore && MainTrack.score < 350 + AddToScore)
        {

            if (Leve1BackGround.transform.position.x >= 0f && checkBack[0])
            {
                saveLocationLevel = Leve1BackGround.transform.position.x - Time.fixedDeltaTime * (4);
                Leve1BackGround.transform.position = new Vector3(saveLocationLevel, 2.5f, 0.18f);
                mainMapp.transform.position = new Vector3(mainMapp.transform.position.x - Time.fixedDeltaTime * (4), 2.5f, 0.25f);
            }
            else
            {
                //MainTrack.MainMAp.GetComponent<Renderer>().material.mainTexture = MainTrack.map2;
                Leve1BackGround.transform.position = new Vector3(0.0f, 2.5f, 0.018f);
                mainMapp.transform.position = new Vector3(14.5f, 2.5f, 0.018f);
                checkBack[0] = false;
            }
        }
        if (MainTrack.score > 550 + AddToScore && MainTrack.score < 600 + AddToScore)
        {

            if (Leve2BackGround.transform.position.x >= 0f && checkBack[1])
            {
                saveLocationLevel = Leve2BackGround.transform.position.x - Time.fixedDeltaTime * (4);
                Leve2BackGround.transform.position = new Vector3(saveLocationLevel, 2.5f, 0.18f);
                Leve1BackGround.transform.position = new Vector3(Leve1BackGround.transform.position.x - Time.fixedDeltaTime * (4), 2.5f, 0.25f);
            }
            else
            {
                //MainTrack.MainMAp.GetComponent<Renderer>().material.mainTexture = MainTrack.map3;
                Leve2BackGround.transform.position = new Vector3(0.0f, 2.5f, 0.18f);
                Leve1BackGround.transform.position = new Vector3(14.5f, 2.5f, 0.18f);
                checkBack[1] = false;
            }
        }
        if (MainTrack.score > 800 + AddToScore && MainTrack.score < 830 + AddToScore)
        {

            if (Leve3BackGround.transform.position.x >= 0f && checkBack[2])
            {
                saveLocationLevel = Leve3BackGround.transform.position.x - Time.fixedDeltaTime * (4);
                Leve3BackGround.transform.position = new Vector3(saveLocationLevel, 2.5f, 0.18f);
                Leve2BackGround.transform.position = new Vector3(Leve2BackGround.transform.position.x - Time.fixedDeltaTime * (4), 2.5f, 0.25f);

            }
            else
            {
                // MainTrack.MainMAp.GetComponent<Renderer>().material.mainTexture = MainTrack.map1;
                Leve3BackGround.transform.position = new Vector3(0.0f, 2.5f, 0.18f);
                Leve2BackGround.transform.position = new Vector3(14.5f, 2.5f, 0.18f);
                checkBack[2] = false;
            }
        }
        if (MainTrack.score > 1100 + AddToScore && MainTrack.score < 1130 + AddToScore)
        {

            if (Leve4BackGround.transform.position.x >= 0f && checkBack[3])
            {
                saveLocationLevel = Leve4BackGround.transform.position.x - Time.fixedDeltaTime * (4);
                Leve4BackGround.transform.position = new Vector3(saveLocationLevel, 2.5f, 0.18f);
                Leve3BackGround.transform.position = new Vector3(Leve3BackGround.transform.position.x - Time.fixedDeltaTime * (4), 2.5f, 0.25f);
            }
            else
            {
                //MainTrack.MainMAp.GetComponent<Renderer>().material.mainTexture = MainTrack.map4;
                Leve4BackGround.transform.position = new Vector3(0.0f, 2.5f, 0.18f);
                Leve3BackGround.transform.position = new Vector3(14.5f, 2.5f, 0.18f);
                checkBack[3] = false;
            }
        }
        if (MainTrack.score > 1300 + AddToScore && MainTrack.score < 1330 + AddToScore)
        {

            if (mainMapp.transform.position.x >= 0f && checkBack[4])
            {
                saveLocationLevel = mainMapp.transform.position.x - Time.fixedDeltaTime * (4);
                mainMapp.transform.position = new Vector3(saveLocationLevel, 2.5f, 0.18f);
                Leve4BackGround.transform.position = new Vector3(Leve4BackGround.transform.position.x - Time.fixedDeltaTime * (4), 2.5f, 0.25f);
            }
            else
            {
                //MainTrack.MainMAp.GetComponent<Renderer>().material.mainTexture = MainTrack.map4;
                mainMapp.transform.position = new Vector3(0.0f, 2.5f, 0.18f);
                Leve4BackGround.transform.position = new Vector3(14.5f, 2.5f, 0.18f);
                checkBack[4] = false;
            }
        }
        // New Round
        if (MainTrack.score > 1500 + AddToScore)
        {
            AddToScore = AddToScore + 200;
        }
    }
}
