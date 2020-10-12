using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{

    public GameObject point;
    public int rate;
    public float scaleRate = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        point.transform.localScale = new Vector3(scaleRate / rate, scaleRate / rate, scaleRate / rate);
        Camera camera = Camera.main;
        for (float x = 0; x <= rate; x += 1f)
        {
            for (float y = 0; y <= rate; y += 1f)
            {
                Vector2 viewPort = new Vector2(x / rate, y / rate);
                Vector2 pos = camera.ViewportToWorldPoint(viewPort);

                GameObject p = Instantiate(point, pos, Quaternion.identity);
                p.transform.SetParent(point.transform.parent);

                PlumbPosition plumbPosition = p.GetComponent<PlumbPosition>();
                plumbPosition.worldPosition = pos;
                plumbPosition.viewPortPosition = viewPort;
            }
        }
    }
}
