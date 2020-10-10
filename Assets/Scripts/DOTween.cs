using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTween : MonoBehaviour
{

    public int index;

    void Start()
    {
        index = 2;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        switch(index)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(-.7f, .5f);
                    index += 1;
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(-2f, .5f);
                    index--;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(.7f, .5f);
                    index += 1;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(-.7f, .5f);
                    index--;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(2f, .5f);
                    index += 1;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    gameObject.GetComponent<Transform>().DOLocalMoveX(.7f, .5f);
                    index--;
                }
                break;
        }
    }
}
