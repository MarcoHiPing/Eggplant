using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public abstract class BaseCharacterController : MonoBehaviour
{
    [Space]
    [Header("Character Controls")]
    public PlayerControls controls;

    [Header("Ability Cast Checker")]
    public AbilityCastChecker abilityCastChecker;

    
    public virtual void Awake()
    {
        controls = new PlayerControls();
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

}
