using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public float rate = 0.01f;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,Raycaster.instance.targetPosition,rate);
    }
}
