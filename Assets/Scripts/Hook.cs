using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;


// Attached to gauntlet
public class Hook : CharacterAbility
{
    public AudioClip hookConfirmSound;
    public Transform defaultParent;
    public GauntletController gauntletController;
    public float hookSpeed = 20f;

    private Rigidbody hook;
    private TrailRenderer trail;
    private Vector3 defaultPos;

    void Start()
    {
        hook = GetComponent<Rigidbody>();
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
        defaultPos = transform.localPosition;
    }

    void Update()
    {
        
    }

    public override void ResetAbility()
    {
        trail.enabled = false;
        transform.SetParent(defaultParent);
        transform.localPosition = defaultPos;
    }

    public override void Cast(Transform objectToHook)
    {
        AudioManager.instance.PlayClip(abilitySFX, 0f);
        trail.enabled = true;
        gauntletController.playerMovementController.enabled = false;
        gauntletController.GetComponent<Rigidbody>().velocity = Vector3.zero;

        hook.isKinematic = false;
        transform.SetParent(null);
        var launchDirection = objectToHook.position - hook.transform.position;
        hook.AddForce(launchDirection * hookSpeed, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Hookable"))
        {
            AudioManager.instance.PlayClip(hookConfirmSound, 0f);
            hook.velocity = Vector3.zero;
            hook.isKinematic = true;
            gauntletController.HookMotion(col.transform.position);
        }
    }
}
