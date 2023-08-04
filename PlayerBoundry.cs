using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundry : MonoBehaviour
{
    

   
    void Update()
    {
        if(transform.position.x < -10.6f)
        {
            transform.position = new Vector3(-10.6f, transform.position.y, transform.position.z);
        }
    }
}
