using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class pausePanel : MonoBehaviour
{
    public GameObject panel;

    public GameObject resumeBtnobje, restartBtnobje, menuBtnobje;

    void Start()
    {
        resumeBtnobje.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
        restartBtnobje.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
        menuBtnobje.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        
    }

    public void pausePaneliAc()
    {
        OpenButtons();
    }

    public void resumeBtn()
    {
        Time.timeScale = 1;
        CloseButtons(0);
    }

    public void restartBtn()
    {
        Time.timeScale = 1;
        CloseButtons(1);
    }

    public void menuBtn()
    {
        Time.timeScale = 1;
        CloseButtons(2);
    }

    void OpenButtons()
    {
        panel.SetActive(true);
        resumeBtnobje.GetComponent<RectTransform>().DOScale(1, .3f).SetEase(Ease.OutBack);
        restartBtnobje.GetComponent<RectTransform>().DOScale(1, .3f).SetEase(Ease.OutBack);
        menuBtnobje.GetComponent<RectTransform>().DOScale(1, .3f).SetEase(Ease.OutBack).OnComplete(() => Time.timeScale = 0);
    }

    void CloseButtons(int x)
    {
        resumeBtnobje.GetComponent<RectTransform>().DOScale(.3f, .3f).SetEase(Ease.InBack);
        restartBtnobje.GetComponent<RectTransform>().DOScale(.3f, .3f).SetEase(Ease.InBack);
        menuBtnobje.GetComponent<RectTransform>().DOScale(.3f, .3f).SetEase(Ease.InBack).OnComplete(() => ClosePanel(x));
    }

    void ClosePanel(int x)
    {
        switch (x)
        {
            case 0:
                panel.SetActive(false);
                break;

            case 1:
                panel.SetActive(false);
                SceneManager.LoadScene("GameScene");
                break;

            case 2:
                panel.SetActive(false);
                SceneManager.LoadScene("MenuScene");
                break;

        }
    }
}
