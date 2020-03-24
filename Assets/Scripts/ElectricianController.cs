using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class ElectricianController : BaseCharacterController
{
    public CharacterAbility zap;

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    public  void Start()
    {
        
        //controls.Electrician.Zap.performed += CastAbility;
        //controls.Electrician.AbilityActivate.started += ActiavateAbility;
        //controls.Electrician.AbilityActivate.canceled += DeactivateAbility;
        //controls.Electrician.TargetSwitch.started += SwitchTarget;
        //Debug.Log("GAME: " + Gamepad.current.name);

    }
   
    public void ActiavateAbility(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        Debug.Log("ACTIVATE ABILITY");
        abilityCastChecker.ActivateAbility();
    }

    public void DeactivateAbility(InputAction.CallbackContext obj)
    {
        if (!obj.canceled)
            return;
        abilityCastChecker.DeactivateAbility();

    }
    public void SwitchTarget(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        abilityCastChecker.SwitchTarget(obj.ReadValue<Vector2>());

    }
    //Zap
    public void CastAbility(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        if (abilityCastChecker.closestObject != null)
        {
            zap.Cast(abilityCastChecker.closestObject.transform);
            abilityCastChecker.ResetAbility();
        }
    }

    public  void Update()
    {
        abilityCastChecker.UpdateSelection();
      
    }
}