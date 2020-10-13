using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButonControl : MonoBehaviour
{
    public GameObject startBtn, exitBtn;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoGameScene()
    {
        startBtn.GetComponent<Transform>().DOScale(.3f, .3f).SetEase(Ease.InBack).OnComplete(Run);
    }

    public void GoExit()
    {
        exitBtn.GetComponent<Transform>().DOScale(.3f, .3f).SetEase(Ease.InBack).OnComplete(Exit);
    }

    void Run()
    {
        SceneManager.LoadScene("GameScene");
    }

    void Exit()
    {
        Application.Quit();
    }
}
