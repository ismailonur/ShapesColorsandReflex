using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSekilCreate : MonoBehaviour
{
    public GameObject[] shapes;

    public Color[] materialColors;

    public GameObject[] sekiller;

    KarakterCreate karakterCreate;

    private void Awake()
    {
        karakterCreate = FindObjectOfType<KarakterCreate>();
    }

    void Start()
    {
        SekilOlusturucu();
    }


    void Update()
    {

    }

    void SekilOlusturucu()
    {
        foreach (GameObject sekil in sekiller)
        {
            int rnd = Random.Range(0, shapes.Length);
            GameObject shape = Instantiate(shapes[rnd], sekil.transform.position, Quaternion.Euler(-90, 0, 0));
            shape.transform.SetParent(sekil.transform);

            //color
            rnd = Random.Range(0, materialColors.Length);
            shape.GetComponent<MeshRenderer>().material.color = materialColors[rnd];
            Destroy(shape.GetComponent<SekilHareket>());
            Destroy(shape.GetComponent<CarpismaKontrol>());
            Destroy(shape.GetComponent<DestroyScript>());
            //shape.transform.SetAsFirstSibling();
        }
    }
}
