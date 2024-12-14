using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{

    public float[] values;


    void Start()
    {
        foreach (float value in values)
        {
            print(value);
        }

        values = new float[10];


        values[0] = 5.0f;
        values[2] = 1.0f;
        values[9] = 10.0f;
    }

}

