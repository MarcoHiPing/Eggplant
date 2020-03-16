using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CustomCameraFollow : MonoBehaviour
{
    public List<Transform> players = new List<Transform>();
    public Transform cameraFocusObject;
    public float maxDistanceApart = 15f;

    public CinemachineVirtualCamera currCamera;
    private float defaultFOV;

    void Start()
    {
        currCamera.m_Lens.FieldOfView = 60f;
        defaultFOV = currCamera.m_Lens.FieldOfView;
    }

    void LateUpdate()
    {
        var distance = Vector3.Distance(players[0].position, players[1].position);
        cameraFocusObject.position = players[0].position + (players[1].position - players[0].position) / 2;

        if (distance > maxDistanceApart)
        {
            currCamera.m_Lens.FieldOfView =  (defaultFOV + (distance - maxDistanceApart));

        }
    }

    public void ChangeCamera(CinemachineVirtualCamera newCam)
    {
        currCamera = newCam;
    }
}
