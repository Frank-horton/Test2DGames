using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    private Vector2 _lastClickPos;
    private bool _moving;

    private void Update()
    {
        MoveOnClick();
    }

    private void MoveOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastClickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _moving = true;
        }

        if (_moving && (Vector2)transform.position != _lastClickPos)
        {
            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _lastClickPos, step);
        }
        else
        {
            _moving = false;
        }
    }
}