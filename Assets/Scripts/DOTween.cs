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
        switch (index)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.39f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index += 1;
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.1481481f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index--;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.62f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index += 1;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.39f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index--;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.8518519f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index += 1;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(0.62f, 1f));
                    gameObject.GetComponent<Transform>().DOLocalMoveX(pos.x, .5f);
                    index--;
                }
                break;
        }
    }

}
