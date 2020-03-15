using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEmission : MonoBehaviourPun
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (PhotonNetwork.NickName.ToLower().Contains("deaf"))
        {
            audioSource.Stop();
            Debug.Log("DEAF");
        }
            
    }

    void Update()
    {
        
    }
}
