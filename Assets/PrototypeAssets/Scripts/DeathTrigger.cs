﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GameManager.Instance.RespawnPlayer();
    }
}