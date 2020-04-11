using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;

public class Raycaster : MonoBehaviour
{
    Transform currentCamera;
    [SerializeField] Transform MainCamera, VRCamera;
    [SerializeField] GameObject tartgetObject;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (Physics.Raycast(currentCamera.position,currentCamera.forward))
        {

        }
    }
}
