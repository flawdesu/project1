using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{
    public Transform target;   
    public Vector3 offset;     

    void Update()
    {
        if (target != null) 
        {
            transform.position = target.position + offset; 
        }
    }
}
