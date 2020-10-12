using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SekilCreate : MonoBehaviour
{
    public GameObject[] shapes;
    private List<GameObject> tempShapes;

    public Color[] materialColors;
    private List<Color> tempColors;

    public GameObject[] sekiller;

    KarakterCreate karakterCreate;

    private void Awake()
    {
        karakterCreate = FindObjectOfType<KarakterCreate>();    
    }

    void Start()
    {
        SekilOlusturucu();
        InvokeRepeating("SekilOlusturucu", 5f, 8f);
    }


    void Update()
    {
       
    }

    void SekilOlusturucu()
    {
        tempShapes = new List<GameObject>(shapes);
        tempColors = new List<Color>(materialColors);
        foreach (GameObject sekil in sekiller)
        {
            int rnd = Random.Range(0, tempShapes.Count);
            GameObject shape = Instantiate(tempShapes[rnd], sekil.transform.position, Quaternion.Euler(-90, 0, 0));
            tempShapes.RemoveAt(rnd);
            shape.transform.SetParent(sekil.transform);

            //color
            rnd = Random.Range(0, tempColors.Count);
            shape.GetComponent<MeshRenderer>().material.color = tempColors[rnd];
            tempColors.RemoveAt(rnd);

            //shape.transform.SetAsFirstSibling();
        }
    }
}
