﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Behavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.0f, -0.1f, 0.0f);
    }
}
