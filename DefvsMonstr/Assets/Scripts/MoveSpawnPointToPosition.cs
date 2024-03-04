using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawnPointToPosition : MonoBehaviour
{
    [SerializeField] float procentInCameraPoint;

    private void Start()
    {
        MoveToSpawnPointPosition();
    }

    private void MoveToSpawnPointPosition()
    {
        float camHalfHeight = Camera.main.orthographicSize;

        float camHalfWidth = Camera.main.aspect * camHalfHeight;

        Bounds bounds = GetComponent<SpriteRenderer>().bounds;

        Vector3 topLeftPosition = new Vector3(camHalfWidth, camHalfHeight * procentInCameraPoint, 0);

        topLeftPosition += new Vector3(bounds.size.x * 2, 0, 0);

        transform.position = topLeftPosition;
    }

}
