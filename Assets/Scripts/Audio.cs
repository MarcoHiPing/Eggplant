using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Clip",menuName ="Audios/Clip",order = 1)]
public class Audio : ScriptableObject
{
    public AudioClip clip;
    public string clipName;
    public bool useDefaultAudioClipName;
    public bool use3DSound;
    public bool fadeIn;
    [HideInInspector]
    public float fadeInTime;
    public bool fadeOut;
    [HideInInspector]
    public float fadeOutTime;
    public bool isLooping;
    public float delay;


}
