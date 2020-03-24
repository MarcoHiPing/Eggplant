using System.Xml.Schema;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;
using Vector3 = UnityEngine.Vector3;

public class AbilityCastChecker : MonoBehaviour
{
    [Header("Objects hit (do not initialize)")]
    public Collider[] objectsHit = new Collider[0];

    [Header("Sphere cast Settings")]
    public float abilityDetectRadius;
    public LayerMask layersToHit;
    public Material highlightMat;

    private bool playerOne, canUseAbility;
    [HideInInspector] public float rightStickX, rightStickY;

    [HideInInspector] public GameObject closestObject;
    GameObject previousClosestGameObject;
    private BaseCharacterController cc;
    float closestDistance = 100f;

    private bool abilityTriggered;
    private bool abilityCanceled;
    private bool nextToggled;

    void Start()
    {
        cc = GetComponent<BaseCharacterController>();
    }

    public void ActivateAbility()
    {
        if(!abilityTriggered)
        {
            Debug.Log("Object found");
            ActivateAbilityCheck();
            abilityTriggered = true;
        }    
    }

    public void DeactivateAbility()
    {
        if (abilityTriggered)
        {
            closestObject = null;
            DeactivateAbilityCheck();
            abilityCanceled = true;
            abilityTriggered = false;
        }
    }
    public void SwitchTarget(Vector2 axisVal)
    {
        
        if (abilityTriggered )
        {
            NextClosestAbilitySpot(axisVal);

          
        }
    }

    public void UpdateInput()
    {
        //if (CrossPlatformInputManager.GetAxis(cc.rightTrigger) > 0f && !abilityTriggered)
        //{
        //    Debug.Log("Object found");
        //    ActivateAbilityCheck();
        //    abilityTriggered = true;
        //}

        //if (CrossPlatformInputManager.GetAxis(cc.rightTrigger) <= 0.1f && abilityTriggered)
        //{
        //    closestObject = null;
        //    DeactivateAbilityCheck();
        //    abilityCanceled = true;
        //    abilityTriggered = false;
        //}

        //if ((rightStickX != 0f || rightStickY != 0f) && abilityTriggered && !nextToggled)
        //{
        //    //if(PhotonNetwork.NickName.ToLower().Contains("electrician"))
        //    NextClosestAbilitySpot(new Vector2(rightStickX, rightStickY));

        //    nextToggled = true;
        //}

        //if (rightStickX == 0f && rightStickY == 0f)
        //{
        //    nextToggled = false;
        //}
    }

    public void ResetAbility()
    {
        abilityCanceled = false;
        abilityTriggered = false;
        DeactivateAbilityCheck();
    }

    public void ActivateAbilityCheck()
    {
        if (!canUseAbility)
            return;

        closestDistance = 100f;

        foreach (Collider hit in objectsHit)
        {
            if (Vector3.Distance(hit.transform.position, transform.position) < closestDistance)
            {
                //Debug.Log("DISTANCE: " + Vector3.Distance(hit.transform.position, transform.position));
                if (previousClosestGameObject != null)
                    previousClosestGameObject.GetComponent<AbilitySpot>().Unhighlight();

                closestObject = hit.transform.gameObject;
                closestDistance = Vector3.Distance(hit.transform.position, transform.position);
                previousClosestGameObject = closestObject;
                closestObject.GetComponent<AbilitySpot>().Highlight(highlightMat);
            }
        }
    }

    public void NextClosestAbilitySpot(Vector2 direction)
    {
        // -ve means left, +ve 1 means right
        //Debug.Log("DIR: " + direction);
        if (objectsHit.Length <= 1)
            return;

        float xDir = direction.x;

        GameObject newClosest = closestObject;
        GameObject closestX = closestObject;
        GameObject excludedObject = closestObject;
        excludedObject.GetComponent<AbilitySpot>().Unhighlight();

        closestDistance = 100f;
        float closestXOnY = 100f; // closest box (on x-axis) when traversing up/down. Box should not change diagonally, always straight down/up.


        if (xDir < 0f)
        {
            foreach (Collider hit in objectsHit)
            {
                //Debug.Log("left check: " + (closestX.transform.position.x - hit.transform.position.x) + "  name: " + closestX.name + " " + hit.transform.name);
                if ((Mathf.Abs(hit.transform.position.x - closestX.transform.position.x) < closestDistance) && hit.gameObject != excludedObject)
                {
                    if (hit.transform.position.x < closestX.transform.position.x)
                    {
                        if (previousClosestGameObject != null)
                            previousClosestGameObject.GetComponent<AbilitySpot>().Unhighlight();

                        newClosest = hit.transform.gameObject;
                        closestDistance = closestX.transform.position.x - hit.transform.position.x;
                        previousClosestGameObject = closestX;
                    }
                }
            }
        }
        else if (xDir > 0f)
        {
            foreach (Collider hit in objectsHit)
            {
                if ((Mathf.Abs(hit.transform.position.x - closestX.transform.position.x) < closestDistance) && hit.gameObject != excludedObject)
                {
                    if (hit.transform.position.x > closestX.transform.position.x)
                    {
                        if (previousClosestGameObject != null)
                            previousClosestGameObject.GetComponent<AbilitySpot>().Unhighlight();

                        newClosest = hit.transform.gameObject;
                        closestDistance = Mathf.Abs(hit.transform.position.x - closestX.transform.position.x);
                        previousClosestGameObject = closestX;
                    }
                }
            }
        }

        closestObject = newClosest;

        if (excludedObject == closestObject)
        {
            excludedObject.GetComponent<AbilitySpot>().Highlight(highlightMat);
        }
        else
        {
            closestObject.GetComponent<AbilitySpot>().Highlight(highlightMat);
        }
    }

    public void DeactivateAbilityCheck()
    {
        foreach (Collider hit in objectsHit)
        {
            hit.transform.GetComponent<AbilitySpot>().Unhighlight();
        }
    }

    public void Fire() // This can be moved to a separate script in charge of using abilities or this script can be renamed
    {
        //if (closestObject != null)
        //    Destroy(closestObject);
    }

    public void UpdateSelection()
    {
        //rightStickX = CrossPlatformInputManager.GetAxis(cc.xRightStick);
        //rightStickY = CrossPlatformInputManager.GetAxis(cc.yRightStick);

        objectsHit = Physics.OverlapSphere(transform.position, abilityDetectRadius, layersToHit);

        if (closestObject != null && objectsHit.Length > 0 && !ArrayUtility.Contains(objectsHit, closestObject.GetComponent<Collider>()))
        {
            closestObject.GetComponent<AbilitySpot>().Unhighlight();
            ActivateAbilityCheck();
        }

        if (objectsHit.Length > 0)
        {
            //transform.localScale = Vector3.one * 1.5f;
            canUseAbility = true;
        }
        else
        {
            //transform.localScale = Vector3.one;
            canUseAbility = false;

            if (closestObject != null)
            {
                closestObject.GetComponent<AbilitySpot>().Unhighlight();
                closestObject = null;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, abilityDetectRadius);
    }
}

