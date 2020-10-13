using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SekillerDOTween : MonoBehaviour
{
    GameObject sekil;

    void FixedUpdate()
    {
        if(sekil == null)
        {
            sekil = gameObject.transform.GetChild(0).gameObject;
            sekil.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
            sekil.GetComponent<Transform>().DOScale(.4f, 10f).SetEase(Ease.OutBack);
            Debug.Log("update");
        }
    }
}
