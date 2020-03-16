using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    public SkinnedMeshRenderer mesh;
    public PlayerAttach otherPlayer;
    public Material attachModeMat;
    public float attachMaxDistance = 3f;
    public int matToChangeIndex = 4;

    private bool attached;
    private Material initialMat;
    private BaseCharacterController cc;


    private void Start()
    {
        cc = GetComponent<BaseCharacterController>();
        initialMat = mesh.materials[matToChangeIndex];
    }

    private void Update()
    {
        if (Input.GetButtonDown(cc.attachInput) && gameObject.CompareTag("Player") && Vector3.Distance(transform.position, otherPlayer.transform.position) < attachMaxDistance)
        {
            if (!attached)
                Attach();
            else
                Detach();
        }
    }

    private void Attach()
    {
        attached = true;
        otherPlayer.attached = true;
        otherPlayer.ChangePlayerMesh(attachModeMat);
        mesh.gameObject.SetActive(false);
        transform.SetParent(otherPlayer.transform);
    }

    private void Detach()
    {
        attached = false;
        otherPlayer.attached = false;
        otherPlayer.ChangePlayerMesh(otherPlayer.initialMat);
        mesh.gameObject.SetActive(true);
        transform.SetParent(null);

    }

    private void ChangePlayerMesh(Material newMat)
    {
        var newMaterials = mesh.materials;
        newMaterials[matToChangeIndex] = newMat;
        mesh.materials = newMaterials;
    }
}
