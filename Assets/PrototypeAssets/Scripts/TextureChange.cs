using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class TextureChange : Interactable
{
    public Material materialToChangeTo;

    private bool playerIsNear;
    private Renderer rend;
    private Material defaultMaterial;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        defaultMaterial = rend.material;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.CompareTag("Deaf"))
        {
            ChangeMaterial(materialToChangeTo);
            playerIsNear = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.transform.CompareTag("Deaf"))
        {
            ChangeMaterial(defaultMaterial);
            playerIsNear = false;
        }
    }

    private void ChangeMaterial(Material mat)
    {
        rend.material = mat;
    }

    public override void DoAction()
    {
        if (!playerIsNear)
            return;

        photonView.RPC("RPC_Action", RpcTarget.All);
    }

    [PunRPC]
    private void RPC_Action()
    {
        Destroy(gameObject);
    }
}
