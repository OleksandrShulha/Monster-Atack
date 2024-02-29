using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] Transform enPosition;
    public bool go = true;
    public bool isFindTarget = false;
  




    void Start()
    {



    }


    // Update is called once per frame
    void Update()
    {

        MoveToTarget();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boom")
        {
            go = false;
        }
    }




    public void MoveToTarget()
    {
        if (go == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, enPosition.position, Time.deltaTime * speed);
        }
        if (transform.position == enPosition.position)
        {
            go = false;
        }
        if (isFindTarget == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, enPosition.position, Time.deltaTime * speed);
        }



            List<GameObject> enemyes = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
            if (enemyes.Count > 0)
            {
                go = false;
                isFindTarget = true;

                float curentDist = Vector3.Distance(enemyes[0].transform.position, transform.position);
                enPosition = enemyes[0].transform;
                Debug.Log("Count enemy: " + enemyes.Count);
                int i = 1;
                foreach (GameObject go in enemyes)
                {
                    
                    float dist = Vector3.Distance(go.transform.position, transform.position);
                    
                    Debug.Log("dist to enemy " + i + " = " + dist);
                    i++;
                    if(dist < curentDist)
                    {
                        enPosition = go.transform;
                    }
                    
                }
            }
            else
            {
            isFindTarget = false;
            }
        
    }

}

