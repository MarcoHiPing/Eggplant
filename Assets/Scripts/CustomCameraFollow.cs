using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CustomCameraFollow : MonoBehaviour
{
    [SerializeField]List< Transform> targets;
    public Transform centerObject;
    public float maxDistanceApart = 15f;

    CinemachineVirtualCamera currCamera;
    private float defaultFOV;
    public float player1Weight;
    public float playeer2Weight;
    Bounds cameraBound;
    Vector3 velocity;
    [SerializeField]float maxZoom, minZoom;

    void Start()
    {
        currCamera = GetComponent<CinemachineVirtualCamera>();
        currCamera.m_Lens.FieldOfView = 60f;
        defaultFOV = currCamera.m_Lens.FieldOfView;
        cameraBound = new Bounds();
    
    }
    private void Update()
    {
       
        
    }
    void LateUpdate()
    {
        //var distance = Vector3.Distance(player1.position, player2.position);
        //cameraFocusObject.position = player1.position + (player2.position - player1.position) / 2;

        //if (distance > maxDistanceApart)
        //{
        //    currCamera.m_Lens.FieldOfView =  (defaultFOV + (distance - maxDistanceApart));

        //}
        Vector3 centerPos = GetEncapsulatedCameraBound().center;
        centerObject.position = Vector3.SmoothDamp(centerObject.position, centerPos,ref velocity,Time.deltaTime);
        float Fov = Mathf.Lerp(minZoom, maxZoom, GetEncapsulatedCameraBound().size.x/40f);
        //currCamera.m_Lens.FieldOfView = Mathf.Lerp(currCamera.m_Lens.FieldOfView, Fov, Time.deltaTime);
        
    }
    Bounds GetEncapsulatedCameraBound()
    {

        cameraBound = new Bounds(targets[0].position, Vector3.zero);
        foreach (var player in targets)
        {
            cameraBound.Encapsulate(player.position);
        }


        return cameraBound;
    }

    public void ChangeCamera(CinemachineVirtualCamera newCam)
    {
        currCamera = newCam;
    }
}
