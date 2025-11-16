using System;
using UnityEngine;
using Zenject;

public class CameraRaycast : MonoBehaviour
{
    [SerializeField] Camera cameraToRaycast;
    [SerializeField] Vector2 raycastPosition;
    [SerializeField] private string PlayerLayerString = "Player";

    private RaycastHit hit;
    private LayerMask playerMask;
    private float maxDistance = 1000f;

    private void Awake()
    {
        playerMask = LayerMask.GetMask(PlayerLayerString);
    }

    internal void TryInteracting()
    {
        if (Physics.Raycast(cameraToRaycast.ViewportPointToRay(raycastPosition), out hit, maxDistance, playerMask))
        {
            LayerMask layerHit = hit.transform.gameObject.layer;
            Debug.Log("Hit Player Layer: ");
        }
    }
}
