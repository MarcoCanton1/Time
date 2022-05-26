using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContarSeg : MonoBehaviour
{
    public float timeElapsed;

    void Start()
    {
        timeElapsed = 0;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timeElapsed += Time.deltaTime;
        }
        else
        {
            timeElapsed = 0;
        }
        Debug.Log(Mathf.Floor(timeElapsed));
        Debug.Log(Mathf.Floor(Time.time));
    }
}
