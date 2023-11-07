using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class audiomanager : MonoBehaviour
{
    [Header ("-----------sources-----------")]
    [SerializeField] AudioSource knuppelSFX;
    [SerializeField] AudioSource BGM;

    [Header ("-----------clips-----------")]
    public AudioClip Ballhit;
    public AudioClip BGMclip;

    private void Start()
    {
        knuppelSFX.clip = Ballhit;
        BGM.clip = BGMclip;
        BGM.Play();
    }

    public void playKnuppel(AudioClip clip)
    {
        knuppelSFX.PlayOneShot(clip);
    }
}
