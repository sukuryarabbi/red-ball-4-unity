using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    

    private float cameraSpeed = 1;

    void Start()
    {
       
    }

    
    void Update()
    {
        

        if(target.position.x < 0){

            transform.position = Vector3.Slerp(transform.position, new Vector3(1, 0, transform.position.z), cameraSpeed);
        }

        if(target.position.x >= 0)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, 0, transform.position.z), cameraSpeed);
        }

        if(target.position.x >50) {

            transform.position = Vector3.Slerp(transform.position, new Vector3(50, 0, transform.position.z), cameraSpeed);
        }

        

    }
}
