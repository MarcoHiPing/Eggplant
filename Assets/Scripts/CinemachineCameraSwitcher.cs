using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CinemachineCameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private List<CinemachineVirtualCamera> vCams;
    [SerializeField] int defaultPriority=0;
    [SerializeField] int maxPriority = 15;

    CinemachineVirtualCamera currentCam;
    private void Start()
    {
        currentCam = vCams[0];
        foreach (var item in vCams)
        {
            item.Priority = defaultPriority;
        }
        currentCam.Priority = maxPriority;
    }
 
    public void SwitchCamera(CinemachineVirtualCamera camToSwitch)
    {
        currentCam.gameObject.SetActive(false);
        currentCam.Priority = defaultPriority;
        camToSwitch.Priority = maxPriority;
        currentCam = camToSwitch;
        currentCam.gameObject.SetActive(true);
    }
}
