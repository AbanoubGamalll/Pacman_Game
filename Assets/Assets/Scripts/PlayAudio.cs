using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayAudio : MonoBehaviour
{

    public Vector3 point;
    public AudioClip clip;
   
    void Start()
    {
        AudioSource.PlayClipAtPoint(clip, point);
    }
}

