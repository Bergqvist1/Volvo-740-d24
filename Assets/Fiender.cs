using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FiendeHANTERARE : MonoBehaviour
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
        float zPos = startZpos + (float)Math.Sin(time);
        Vector3 position = transform.position;
        position.z = zPos;
        transform.position = position;         
        
        

        time += Time.deltaTime *3;

        if(zPos == -8f)
        {
            transform.position = new Vector3(s *-1 ,0,0);
            
        }


    }
}
