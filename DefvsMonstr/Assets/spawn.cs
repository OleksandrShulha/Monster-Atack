using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float timeSpawn = 1f;
    void Start()
    {
        //StartCoroutine(SpawnPlayr());
    }

    IEnumerator SpawnPlayr()
    {


        while (true)
        {
            Instantiate(spawnObject, transform.position, transform.rotation);
            yield return new WaitForSeconds(timeSpawn);

        }

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnObject, transform.position, transform.rotation);
        }
    }
}
