using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterCreate : MonoBehaviour
{

    public GameObject mainCharacter;
    //  public Color[] materialColor;

    GameObject character;
    int hangiSekil;

    void Start()
    {
        hangiSekil = Random.Range(1, 5);
        HangiSekilKontrol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HangiSekilKontrol()
    {
        switch(hangiSekil){
            case 1:
                HangiSekil("sekil1");
                break;
            case 2:
                HangiSekil("sekil2");
                break;
            case 3:
                HangiSekil("sekil3");
                break;
            case 4:
                HangiSekil("sekil4");
                break;
        }
    }

    void HangiSekil(string tag)
    {
        GameObject sekil = GameObject.FindGameObjectWithTag(tag).transform.GetChild(0).gameObject;
        character = Instantiate(sekil, mainCharacter.transform.position, Quaternion.Euler(-90, 0, 0));
        character.transform.SetParent(mainCharacter.transform);
        //Destroy(character.GetComponent<ColorsScript>());
        Destroy(character.GetComponent<SekilHareket>());
    }
}
