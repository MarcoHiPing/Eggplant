using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacterController : MonoBehaviour
{
    [Space]
    [Header("Character Controls")]

    public string xMove;
    public string yMove;
    public string jumpInput;

    public string xRightStick;
    public string yRightStick;
    public string rightTrigger;
    public string abilityCastInput;
    public string attachInput;

    [Header("Ability Cast Checker")]
    public AbilityCastChecker abilityCastChecker;


    void Start()
    {

    }

    public abstract void UpdateInput();
}
