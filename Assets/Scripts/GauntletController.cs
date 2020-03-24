using System;
using Invector.vCharacterController;
using UnityEngine;
using UnityEngine.InputSystem;

public class GauntletController : BaseCharacterController
{
    [Header("Hook Options")]
    public CharacterAbility hook;
    public vThirdPersonInput playerMovementController;
    public Transform moveFromPos;
    public float hookPullForce = 8f;

    private Rigidbody rb;

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
   public  void  Start()
    {
       
        rb = GetComponent<Rigidbody>(); 
      
    }

    public void ActivateAbility(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
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
        abilityCastChecker.SwitchTarget(obj.ReadValue<Vector2>());

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

    public void CastAbility(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        if (abilityCastChecker.closestObject != null)
        {
            hook.Cast(abilityCastChecker.closestObject.transform);
            abilityCastChecker.ResetAbility();
        }
    }

    public  void Update()
    {
        abilityCastChecker.UpdateSelection();
        
    }
}
