using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audioS;
    public AudioClip bg_intro;
    public AudioClip bg_normal;

    private void Awake()
    {

        audioS[0].clip = bg_intro;
        audioS[1].clip = bg_normal;

        double startMusic = AudioSettings.dspTime; 

        audioS[0].PlayScheduled(startMusic);
        audioS[1].PlayScheduled(startMusic + bg_intro.length);

    }


}
