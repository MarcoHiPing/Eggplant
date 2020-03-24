using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GauntletTeleport : MonoBehaviour
{
    public Transform teleportIndicator;
    public float teleporterDistanceMultiplier = 2f;

    private float currentY;

    void Start()
    {
        currentY = teleportIndicator.position.y;
    }

    void Update()
    {
        teleportIndicator.rotation = Quaternion.identity;
    }

    public void Teleport()
    {
        transform.position = teleportIndicator.position;
        //StartCoroutine(TeleportLerp(transform.position, teleportIndicator.position, 10f));
    }

    public void TeleportIndicator(Vector2 direction)
    {
        direction.y *= -1; // Inverse because all y-axis in game is inverse

        //teleportIndicator.position = new Vector3(transform.position.x + Mathf.CeilToInt(direction.x) * teleporterDistanceMultiplier,
        //    currentY, 
        //    transform.position.z + Mathf.CeilToInt(direction.y) * teleporterDistanceMultiplier);

        teleportIndicator.position = new Vector3(transform.position.x + direction.x * teleporterDistanceMultiplier,
            currentY,
            transform.position.z + direction.y * teleporterDistanceMultiplier);

        //StartCoroutine(TeleporterLerp(teleportIndicator.position, newLocation, 500f));
    }


    IEnumerator TeleportIndicatorLerp(Vector3 startPos, Vector3 endPos, float speed)
    {
        Debug.Log("START : " + startPos + "   END: " + endPos);
        float timeStartedLerping = Time.time;
        float lerpPercComplete = 0f;

        while (lerpPercComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            lerpPercComplete = timeSinceStarted / speed;
            endPos.y = currentY;
            teleportIndicator.position = Vector3.Lerp(startPos, endPos, lerpPercComplete);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator TeleportLerp(Vector3 startPos, Vector3 endPos, float speed)
    {
        Debug.Log("START : " + startPos + "   END: " + endPos);
        float timeStartedLerping = Time.time;
        float lerpPercComplete = 0f;

        while (lerpPercComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            lerpPercComplete = timeSinceStarted / speed;
            transform.position = Vector3.Lerp(startPos, endPos, lerpPercComplete);
            yield return new WaitForEndOfFrame();
        }
    }

    public void ResetTeleportIndicator()
    {
        teleportIndicator.position = new Vector3(transform.position.x, transform.position.y + currentY, transform.position.z);
    }
}