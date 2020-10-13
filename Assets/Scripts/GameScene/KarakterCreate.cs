using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KarakterCreate : MonoBehaviour
{
    public GameObject mainCharacter;
    public GameObject[] shapes;

    public int levelIndex;

    GameObject character;
    GameObject sekil;
    int hangiSekil;

    public int childIndex;

    private void Awake()
    {
        childIndex = 0;
    }

    void Start()
    {
        HangiSekilKontrol();
    }

    void Update()
    {

    }

    public void HangiSekilKontrol()
    {
        hangiSekil = Random.Range(1, 5);
        switch (hangiSekil){
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
        Debug.Log(childIndex);
        sekil = GameObject.FindGameObjectWithTag(tag).transform.GetChild(childIndex).gameObject;
        character = Instantiate(sekil, mainCharacter.transform.position, Quaternion.Euler(-90, 0, 0));
        character.transform.localScale = new Vector3(0, 0, 0);
        character.transform.SetParent(mainCharacter.transform);
        character.GetComponent<Transform>().DOScale(.4f, .5f).SetEase(Ease.OutBack);
        if(levelIndex == 1)
        {
            character.GetComponent<MeshRenderer>().material.color = ColorSelect();
        }

        Destroy(character.GetComponent<SekilHareket>());
        Destroy(character.GetComponent<CarpismaKontrol>());
    }

    Color ColorSelect()
    {
        Color[] selectedColor = new Color[4];
        int i = 0;
        foreach(GameObject shape in shapes)
        {
           selectedColor[i] = shape.transform.GetChild(childIndex).GetComponent<MeshRenderer>().material.color;
            i++;
        }

        int rnd = Random.Range(0, selectedColor.Length);
        return selectedColor[rnd];
    }
}
