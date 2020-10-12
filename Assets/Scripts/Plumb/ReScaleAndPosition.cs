using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReScaleAndPosition : MonoBehaviour
{
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        if(index == 0)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.1481481f,1.5f,8));
        }

        if(index == 1)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.39f,1.5f,8));
        }

        if(index == 2)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.62f,1.5f,8));
        }

        if(index == 3)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.8518519f,1.5f,8));
        }


        ReScale();
    }

    // Update is called once per frame
    void ReScale()
    {
        var width = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;
        transform.localScale = new Vector3((float)(width / 9.0), (float)(width / 9.0), (float)(width / 9.0));
    
    }
}
