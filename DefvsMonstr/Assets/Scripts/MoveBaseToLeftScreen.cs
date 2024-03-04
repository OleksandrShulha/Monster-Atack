using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBaseToLeftScreen : MonoBehaviour
{

    private void Start()
    {
        MoveToLeftSide();
    }

    private void MoveToLeftSide()
    {
        float camHalfHeight = Camera.main.orthographicSize;

        float camHalfWidth = Camera.main.aspect * camHalfHeight;


        Bounds bounds = GetComponent<SpriteRenderer>().bounds;

        // Устанавливаем новый вектор в левый угол 
        Vector3 topLeftPosition = new Vector3(-camHalfWidth, 0, 0);

        // Устанавливаем смещение на основе размера объекта
        topLeftPosition -= new Vector3(bounds.size.x / 4, 0, 0);

        transform.position = topLeftPosition;
    }



}
