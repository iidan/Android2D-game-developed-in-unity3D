using UnityEngine;
using System.Collections;

public class MusicControl : MonoBehaviour {

    public AudioSource[] allSoundEffects;
    public AudioSource music;
    private int musicC;
    private int FxSound;

    // Use this for initialization
    void Start () {
        musicC = PlayerPrefs.GetInt("SoundGame");
        FxSound = PlayerPrefs.GetInt("FxSound");

        // Turn on / off music in the Game. 
        if (musicC == 1)
        {
            music.mute = false;
        }
        if (musicC == 2)
        {
            music.mute = true;
        }

        // Tuen on / off the Sound effect int the Game.
        if (FxSound == 1)
        {
            for (int i = 0; i < allSoundEffects.Length; i++)
            {
                allSoundEffects[i].mute = false;
            }
        }
        if (FxSound == 2)
        {
            for (int i = 0; i < allSoundEffects.Length; i++)
            {
                allSoundEffects[i].mute = true;
            }
        }
    }
	
}
