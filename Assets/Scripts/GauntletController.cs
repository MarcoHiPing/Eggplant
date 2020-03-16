using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;

public class GauntletController : BaseCharacterController
{
    [Header("Hook Options")]
    public CharacterAbility hook;
    public vThirdPersonInput playerMovementController;
    public Transform moveFromPos;
    public float hookPullForce = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void HookMotion(Vector3 posToMove)
    {
        var dir = posToMove - moveFromPos.position;
        rb.AddForce(dir * hookPullForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Hookable"))
        {
            playerMovementController.enabled = true;
            hook.ResetAbility();
        }
    }

    public override void UpdateInput()
    {
        abilityCastChecker.UpdateSelection();
        abilityCastChecker.UpdateInput();

        if (Input.GetButtonDown(abilityCastInput))
        {
            if (abilityCastChecker.closestObject != null)
            {
                hook.Cast(abilityCastChecker.closestObject.transform);
                abilityCastChecker.ResetAbility();
            }
        }
    }
}
