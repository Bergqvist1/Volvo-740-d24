using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fiender : MonoBehaviour
{

    float s = -2;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float startZpos = 16f;
        float zPos = startZpos + (float)Math.Sin(time) *10;
        Vector3 position = transform.position;
        position.z = zPos;
        transform.position = position;         
        
        

        time += Time.deltaTime *2;


    }

     void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            other.GetComponent<SpelarePoints>().AddPoints(UnityEngine.Random.Range(1,100));
            Destroy(gameObject);
        }
    }
}
