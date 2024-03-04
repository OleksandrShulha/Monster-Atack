using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float posPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float camHalfHeight = Camera.main.orthographicSize;

        float camHalfWidth = Camera.main.aspect * camHalfHeight;


        Bounds bounds = GetComponent<SpriteRenderer>().bounds;

        // Устанавливаем новый вектор в левый угол 
        Vector3 topLeftPosition = new Vector3(camHalfWidth, camHalfHeight*posPos, 0);

        // Устанавливаем смещение на основе размера объекта
        topLeftPosition += new Vector3(bounds.size.x * 2, 0, 0);

        transform.position = topLeftPosition;

    }
}
