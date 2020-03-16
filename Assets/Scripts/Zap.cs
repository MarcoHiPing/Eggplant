using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using BoxCollider = UnityEngine.BoxCollider;

public class Zap : CharacterAbility
{
    public override void ResetAbility()
    {
        
    }

    public override void Cast(Transform objectToZap)
    {
        objectToZap.GetComponent<ZappableObject>().DoAction();
        AudioManager.instance.PlayClip(abilitySFX, 0f);
    }
}

