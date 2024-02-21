using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] Transform enPosition;
    public bool go = true;
    //public bool target = false;
    public bool isFindTarget = false;
    Transform targetAtacker;
    float curentdistans = 1000f;



    void Start()
    {

        //float dist = Vector3.Distance(enPosition.position, transform.position);
        //Debug.Log(dist);

    }

    private void MoveToTarget()
    {
        if (go == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, enPosition.position, Time.deltaTime * speed);
        }
        if (transform.position == enPosition.position)
        {
            go = false;
        }
        if (isFindTarget)
        {
           //transform.position = Vector3.MoveTowards(transform.position, targetAtacker.position, Time.deltaTime * speed);
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            List<GameObject> enemyes = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
            if (enemyes.Count > 0)
            {
                Debug.Log("Emeny count: " + enemyes.Count);
                go = false;
                
                foreach (GameObject go in enemyes)
                {
                    float dist = Vector3.Distance(go.transform.position, transform.position);
                    if (dist < curentdistans)
                    {
                        curentdistans = dist;
                        //targetAtacker.position = new Vector3(go.transform.position.x, go.transform.position.y);

                    }
                }
                isFindTarget = true;
                Debug.Log("min disr: " + curentdistans);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //FindEnemy();
        MoveToTarget();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boom")
        {
            go = false;
        }
    }



    private void FindEnemy()
    {
        List<GameObject> enemyes = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));

        if (enemyes.Count > 0)
        {

            Debug.Log(enemyes.Count);
            go = false;
            //isFindTarget = true;
            var curentdistans = 1000f;
            foreach (GameObject go in enemyes)
            {
                float dist = Vector3.Distance(go.transform.position, transform.position);
                if (dist < curentdistans)
                {
                    curentdistans = dist;
                    targetAtacker.position = new Vector3(go.transform.position.x, go.transform.position.y);

                }
            }
            isFindTarget = true;
            Debug.Log(curentdistans);
          

        }
        else
        {
            isFindTarget = false;
        }
    }
}

