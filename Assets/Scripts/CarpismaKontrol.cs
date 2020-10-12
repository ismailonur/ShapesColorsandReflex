using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarpismaKontrol : MonoBehaviour
{
    KarakterCreate karakterCreate;

    bool gameOver = true;

    private void Awake()
    {
        karakterCreate = FindObjectOfType<KarakterCreate>();
        Time.timeScale = 3;
    }

    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(karakterCreate.levelIndex == 0)
        {
            if (other.tag == gameObject.tag)
            {
                gameOver = false;
                karakterCreate.childIndex++;

                StartCoroutine(YanmaKontrol());
                Debug.Log("level");
            }
            else if (other.tag != gameObject.tag)
            {
                if(gameOver == true)
                {
                    Time.timeScale = 0;
                }
            }
        }

        if(karakterCreate.levelIndex == 1)
        {
            Color characterColor = other.GetComponent<MeshRenderer>().material.color;//karakter
            Color currentColor = gameObject.GetComponent<MeshRenderer>().material.color;//şekil
            if (currentColor == characterColor)
            {
                gameOver = false;
                karakterCreate.childIndex++;
                karakterCreate.mainCharacter.transform.GetChild(0).gameObject.GetComponent<Transform>().DOScale(0, 1f).SetEase(Ease.InBack).OnComplete(objeSilme);
                StartCoroutine(YanmaKontrol());
                Debug.Log("level 2");
            }
            else
            {
                if (gameOver == true)
                {
                    Time.timeScale = 0;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if(karakterCreate.levelIndex == 0)
        {
            if(other.tag == gameObject.tag)
            {
                karakterCreate.mainCharacter.transform.GetChild(0).gameObject.GetComponent<Transform>().DOScale(0, .5f).SetEase(Ease.InBack).OnComplete(objeSilme);
                Destroy(karakterCreate.mainCharacter.transform.GetChild(0).gameObject);
                Debug.Log("wxit");
                karakterCreate.HangiSekilKontrol();
            }
        }
        
    }

    IEnumerator YanmaKontrol()
    {
        gameOver = false;
        yield return new WaitForSeconds(6f);
        gameOver = true;
    }

    void objeSilme()
    {
        Destroy(karakterCreate.mainCharacter.transform.GetChild(0).gameObject);
    }
}
