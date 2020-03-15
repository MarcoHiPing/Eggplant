using System;
using UnityEngine;


public class CameraPlayerFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 7.5f, 0f);

    private MovementTest moveTest;

    public void Start()
    {
        moveTest = FindObjectOfType<MovementTest>();
        target = new GameObject().transform;
        target.name = "CameraFollowObject";

    }

    private void LateUpdate()
    {
        target.position = moveTest.player2.position + (moveTest.player1.position - moveTest.player2.position) / 2;
        transform.position = target.position + offset;
    }
}
