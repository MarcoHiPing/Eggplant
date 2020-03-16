using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterAbility : MonoBehaviour
{
    public AudioClip abilitySFX;
    public abstract void ResetAbility();
    public abstract void Cast(Transform castObject);
}
