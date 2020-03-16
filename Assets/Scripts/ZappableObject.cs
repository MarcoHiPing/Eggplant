using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZappableObject : MonoBehaviour
{
    public UnityEvent onZapEvent;

    public void DoAction()
    {
        onZapEvent.Invoke();
    }

    public void BABS()
    {
        
    }
}
