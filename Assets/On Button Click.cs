using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public void PlayAudio()
    {
        source.PlayOneShot(clip);
    }
}
