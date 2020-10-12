using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    KarakterCreate karakterCreate;

    private void Awake()
    {
        karakterCreate = FindObjectOfType<KarakterCreate>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y < -10)
        {
            //Destroy(gameObject);
        }
    }
}
