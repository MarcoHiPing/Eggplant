using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private Transform raycastPoint;
    [SerializeField] private float maxRaycastDistance = 5f;
    [SerializeField] private LayerMask raycastLayers;
    private RaycastHit castHit;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.DrawRay(raycastPoint.position, raycastPoint.transform.forward * maxRaycastDistance, Color.red);
        if (Physics.Raycast(raycastPoint.position, raycastPoint.transform.forward, out castHit, maxRaycastDistance, raycastLayers))
        {
            if(Input.GetKeyDown(KeyCode.E))
                castHit.transform.GetComponent<Interactable>().DoAction();
        }
    }
}
