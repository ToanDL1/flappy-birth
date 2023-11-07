using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Desgin Patten Singleton
    public static SoundController instance;
    private AudioSource audioComponent;


    public void Awake()
    {
        audioComponent = this.gameObject.GetComponent<AudioSource>();
        instance = this;
    }
    public void PlaySound(string clipName)
    {

        AudioClip clip = (AudioClip)Resources.Load("Sounds/" + clipName);
        Debug.Log(clip);

        audioComponent.PlayOneShot(clip, 0.5f);
    }
}
