using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;

public class ElectricianController : BaseCharacterController
{
    public CharacterAbility ability;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void UpdateInput()
    {
        abilityCastChecker.UpdateSelection();
        abilityCastChecker.UpdateInput();

        if (Input.GetButtonDown(abilityCastInput))
        {
            if (abilityCastChecker.closestObject != null)
            {
                ability.Cast(abilityCastChecker.closestObject.transform);
                abilityCastChecker.ResetAbility();
            }
        }
    }
}