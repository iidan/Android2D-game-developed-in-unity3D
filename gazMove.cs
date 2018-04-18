﻿using UnityEngine;
using System.Collections;

public class gazMove : MonoBehaviour {

    private int saveNum;
    private float maxWidth = -2.1f;
    private float minWidth = -2.7f;
    void Start()
    {
        saveNum = Random.Range(1, 3);
    }
    void Update()
    {
        transform.position -= new Vector3((2f) * Time.deltaTime, 0.0f, 0.0f);

        if (saveNum == 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
        }
        else if (saveNum == 2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.03f, transform.position.z);
        }
        if (transform.position.y >= maxWidth)
        {
            saveNum = 2;
        }
        else if (transform.position.y <= minWidth)
        {
            saveNum = 1;
        }
    }
}
