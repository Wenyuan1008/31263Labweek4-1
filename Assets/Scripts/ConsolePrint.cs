using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConsolePrint : MonoBehaviour
{
    private int i = 3;

    void Update()
    {
        Debug.Log($"{gameObject.name}:{i}");
        i++;
    }
}

