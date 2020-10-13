using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuDOTween : MonoBehaviour
{
    public GameObject startBtn, exitBtn;

    void Start()
    {
        startBtn.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
        exitBtn.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);

        butonlar();
    }

    void Update()
    {
        
    }

    void butonlar()
    {
        startBtn.GetComponent<Transform>().DOScale(1, 1f).SetEase(Ease.OutBack);
        exitBtn.GetComponent<Transform>().DOScale(1, 1f).SetEase(Ease.OutBack);
    }
}
