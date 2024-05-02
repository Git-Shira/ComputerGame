using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerafollowScript : MonoBehaviour
{


    public Transform target;

    private Vector3 _cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + _cameraOffset;
    }
} 
 