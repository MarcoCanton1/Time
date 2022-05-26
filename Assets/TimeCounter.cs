using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text timeCountertxt;
    float elapsedTime;

    bool isPaused = false;

    void Start()
    {
        elapsedTime = 0;
    }

    void Update()
    {
        timeCountertxt.text = Mathf.Floor(Time.time).ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;
        }

        if (isPaused == false)
        {
                elapsedTime += Time.deltaTime;
        }
    }
}
