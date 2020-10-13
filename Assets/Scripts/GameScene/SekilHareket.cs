using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SekilHareket : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        

    
    }


}
