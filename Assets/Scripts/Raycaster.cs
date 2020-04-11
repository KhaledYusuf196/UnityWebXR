using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;

public class Raycaster : MonoBehaviour
{
    [HideInInspector]public Vector3 targetPosition;
    Transform currentCamera;
    [SerializeField] Transform MainCamera, VRCamera;
    static Raycaster raycaster;
    static Raycaster instance => raycaster;

    private void Awake()
    {
        if(raycaster == null)
        {
            raycaster = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(WebXRManager.Instance.xrState == WebXRState.ENABLED)
        {
            currentCamera = VRCamera;
        }
        else
        {
            currentCamera = MainCamera;
        }
        if (Physics.Raycast(currentCamera.position,currentCamera.forward, out RaycastHit hit))
        {
            targetPosition = hit.point;
            Debug.Log(targetPosition);
        }
    }
}
